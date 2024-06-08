using System;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using static System.Net.WebRequestMethods;

namespace Maple.MonoGameAssistant.UILogic;

public class GameHttpClient
{
    public ILogger Logger { get; }
    HttpClient HttpClient { get; }
    Uri GameBaseUri { get; }
    //public MonoWebApiToken WebApiToken { get; }

    public GameHttpClient(ILogger logger, HttpClient httpClient, Uri gameBaseUri)
    {
        this.Logger = logger;
        this.HttpClient = httpClient;
        this.GameBaseUri = gameBaseUri;
    }

    public static JsonSerializerOptions JsonOptions { get; } = new()
    {
        Converters = { new IntPtrJsonConverter() },
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
    };


    private async Task<bool> TrySaveStream2FileAsync<T_POST>(string url, T_POST post, FileStream fileStream)
    {
        try
        {
            using var reqMsg = new HttpRequestMessage(HttpMethod.Post, new Uri(GameBaseUri, url))
            {
                Content = JsonContent.Create(post, options: JsonOptions),
            };
            using var httpMsg = await this.HttpClient.SendAsync(reqMsg).ConfigureAwait(false);
            if (httpMsg.IsSuccessStatusCode)
            {
                await httpMsg.Content.CopyToAsync(fileStream);
                //var stream = await httpMsg.Content.ReadAsStreamAsync().ConfigureAwait(false);
                //await stream.CopyToAsync(fileStream).ConfigureAwait(false);
                return true;
            }

        }
        catch (GameContextException ex)
        {
            //web app 内部业务异常
            this.Logger.LogInformation("{ex}", ex);
        }
        catch (Exception ex)
        {
            //未知的异常
            this.Logger.LogError("{ex}", ex);
        }
        return false;
    }


    private Task<MonoResultDTO<T_DTO>> SendAsync<T_DTO, T_POST>(string url, T_POST? req)
       => SendAsync<T_DTO, T_POST>(this.HttpClient, url, req);

    private static async Task<MonoResultDTO<T_DTO>> SendAsync<T_DTO, T_POST>(HttpClient http, string url, T_POST? req)
    {
        using var reqMsg = req is null ? new HttpRequestMessage(HttpMethod.Get, url) :
                   new HttpRequestMessage(HttpMethod.Post, url)
                   {
                       Content = JsonContent.Create(req, mediaType: default, MonoJsonContext.Default.Options)
                   };

        using var httpMsg = await http.SendAsync(reqMsg).ConfigureAwait(false);
        if (false == httpMsg.IsSuccessStatusCode)
        {
            return GameContextException.Throw<MonoResultDTO<T_DTO>?>($"ERROR {nameof(GameHttpClient)}:{httpMsg.StatusCode}");
        }
        var dto = await httpMsg.Content.ReadFromJsonAsync<MonoResultDTO<T_DTO>>(options: JsonOptions).ConfigureAwait(false);
        if (dto is null)
        {
            GameContextException.Throw($"ERROR {nameof(GameHttpClient)} Json");
        }
        return dto;
    }

    private async ValueTask<MonoResultDTO<T_DTO>> TrySendAsync<T_DTO, T_POST>(string url, T_POST? post)
    {
        try
        {
            var dto = await SendAsync<T_DTO, T_POST>(url, post).ConfigureAwait(false);
            return dto;
        }
        catch (GameContextException ex)
        {
            //web app 内部业务异常
            this.Logger.LogInformation("{ex}", ex);
            return MonoResultDTO.GetBizError<T_DTO>(ex);
        }
        catch (Exception ex) when (ex.InnerException is TimeoutException)
        {
            return MonoResultDTO.GetBizError<T_DTO>(0, "Timeout:The service is not ready");
        }
        catch (Exception ex)
        {
            //未知的异常
            this.Logger.LogError("{ex}", ex);
            return MonoResultDTO.GetSystemError<T_DTO>(ex.Message);
        }

    }

    public static async Task<MonoResultDTO<T_DTO>> TryGetGameInfoAsync<T_DTO>(HttpClient http)
    {
        return await SendAsync<T_DTO, MonoRequestDTO>(http, "/game/info", default).ConfigureAwait(false);

    }


    public ValueTask<MonoResultDTO<MonoImageInfoDTO[]>> PostEnumImagesAsync()
    {
        return this.TrySendAsync<MonoImageInfoDTO[], MonoRequestDTO>("/mono/EnumImages", default);
    }
    public ValueTask<MonoResultDTO<MonoClassInfoDTO[]>> PostEnumClassesAsync(nint imagePointer)
    {
        return this.TrySendAsync<MonoClassInfoDTO[], MonoPointerRequestDTO>("/mono/EnumClasses", new MonoPointerRequestDTO() { Pointer = imagePointer });
    }

    //public async ValueTask<MonoResultDTO<IReadOnlyList<MonoClassInfoDTO>>> PostEnumClassesAsyncEx(nint imagePointer)
    //{

    //    //var postPage = new MonoPostPageDTO<nint>() { Data = imagePointer, PageNum = 0, PageSize = 2250 };

    //    //var firstResultDTO = await this.TryPostAsync<MonoPageDTO<MonoClassInfoDTO>, MonoPostPageDTO<nint>>("/api/EnumClasses_Page", postPage);
    //    //if (firstResultDTO.TryGet(out var firstPageDTO))
    //    //{
    //    //    var pageDatas = new List<MonoClassInfoDTO>(firstPageDTO.TotalSize);
    //    //    pageDatas.AddRange(firstPageDTO.DATAS);
    //    //    for (int i = 1; i < firstPageDTO.PageCount; ++i)
    //    //    {
    //    //        postPage.PageNum = i;
    //    //        var nextResultDTO = await this.TryPostAsync<MonoPageDTO<MonoClassInfoDTO>, MonoPostPageDTO<nint>>("/api/EnumClasses_Page", postPage);
    //    //        if (nextResultDTO.TryGet(out var nextPageDTO))
    //    //        {
    //    //            pageDatas.AddRange(nextPageDTO.DATAS);
    //    //        }
    //    //    }
    //    //    pageDatas.Sort(static (x, y) => string.Compare(x.FullName, y.FullName));
    //    //    return MonoResultDTO.GetOk<IReadOnlyList<MonoClassInfoDTO>>(pageDatas);
    //    //}
    //    return MonoResultDTO.GetBizError<IReadOnlyList<MonoClassInfoDTO>>(0, $"{firstResultDTO.CODE}:{firstResultDTO.MSG}");
    //}

    [Obsolete("remove...")]
    public ValueTask<MonoResultDTO<MonoMethodInfoDTO[]>> PostEnumMethodsAsync(nint classPointer)
    {
        return this.TrySendAsync<MonoMethodInfoDTO[], MonoPointerRequestDTO>("/mono/EnumMethods", new MonoPointerRequestDTO() { Pointer = classPointer });
    }
    [Obsolete("remove...")]
    public ValueTask<MonoResultDTO<MonoFieldInfoDTO[]>> PostEnumFieldsAsync(nint classPointer, EnumMonoFieldOptions fieldOptions = EnumMonoFieldOptions.EnumAndConstAndStatic)
    {
        return this.TrySendAsync<MonoFieldInfoDTO[], MonoClassDetailRequestDTO>("/mono/EnumFields", new MonoClassDetailRequestDTO() { Pointer = classPointer, FieldOptions = fieldOptions });
    }
    [Obsolete("remove...")]
    public ValueTask<MonoResultDTO<MonoClassInfoDTO[]>> PostEnumParentClassesAsync(nint classPointer)
    {
        return this.TrySendAsync<MonoClassInfoDTO[], MonoPointerRequestDTO>("/mono/EnumParentClasses", new MonoPointerRequestDTO() { Pointer = classPointer });
    }


    public ValueTask<MonoResultDTO<MonoClassDetailDTO>> PostEnumClassDetailAsync(nint classPointer, EnumMonoFieldOptions fieldOptions = EnumMonoFieldOptions.EnumAndConstAndStatic)
    {
        return this.TrySendAsync<MonoClassDetailDTO, MonoClassDetailRequestDTO>("/mono/EnumClassDetail", new MonoClassDetailRequestDTO { Pointer = classPointer, FieldOptions = fieldOptions });
    }

    public ValueTask<MonoResultDTO<MonoObjectInfoDTO[]>> PostEnumObjectsAsync(nint imagePointer)
    {
        return this.TrySendAsync<MonoObjectInfoDTO[], MonoPointerRequestDTO>("/mono/EnumObjects", new MonoPointerRequestDTO { Pointer = imagePointer, });
    }

    public Task<bool> TrySaveClassDetail2FileAsync(nint classPointer, FileStream fileStream)
    {
        return this.TrySaveStream2FileAsync("/mono/EnumClassDetail", new MonoClassDetailRequestDTO { Pointer = classPointer, FieldOptions = EnumMonoFieldOptions.EnumAndConst }, fileStream);
    }



}
