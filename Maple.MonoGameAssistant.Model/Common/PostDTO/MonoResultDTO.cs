using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Model
{

    public class MonoResultDTO
    {
        public int CODE { set; get; }
        public string? MSG { set; get; }

        public static MonoResultDTO<T_DTO> GetOk<T_DTO>(T_DTO dto)
            where T_DTO : class
        {
            return new MonoResultDTO<T_DTO>()
            {
                CODE = (int)EnumMonoCommonCode.OK,
                DATA = dto
            };
        }

        public static MonoResultDTO<T_DTO> GetBizError<T_DTO>(int code, string msg)
        {
            return new MonoResultDTO<T_DTO>()
            {
                CODE = code,
                MSG = msg
            };
        }

        public static MonoResultDTO GetBizError(MonoCommonException exception)
        {
            return new MonoResultDTO()
            {
                CODE = exception.Code,
                MSG = exception.Message
            };
        }
        public static MonoResultDTO<T_DTO> GetBizError<T_DTO>(MonoCommonException exception)
        {
            return new MonoResultDTO<T_DTO>()
            {
                CODE = exception.Code,
                MSG = exception.Message
            };
        }

        public static MonoResultDTO GetSystemError(string msg)
        {
            return new MonoResultDTO()
            {
                CODE = (int)EnumMonoCommonCode.SYSTEM_EXCEPTION,
                MSG = msg
            };
        }

        public static MonoResultDTO<T_DTO> GetSystemError<T_DTO>(string msg)
        {
            return new MonoResultDTO<T_DTO>()
            {
                CODE = (int)EnumMonoCommonCode.SYSTEM_EXCEPTION,
                MSG = msg
            };
        }

        public static MonoResultDTO<T_DTO> GetSkipError<T_DTO>()
        {
            return new MonoResultDTO<T_DTO>()
            {
                CODE = (int)EnumMonoCommonCode.SKIP,
            };
        }

        public static MonoResultDTO GetSystemUnauthorized(string msg)
        {
            return new MonoResultDTO()
            {
                CODE = (int)EnumMonoCommonCode.UNAUTHORIZED,
                MSG = msg
            };
        }

    }


    public class MonoResultDTO<T_DTO> : MonoResultDTO
    {
        public T_DTO? DATA { set; get; }


        public bool TryGet([MaybeNullWhen(false)] out T_DTO dto)
        {
            dto = DATA;
            return this.CODE == (int)EnumMonoCommonCode.OK;
        }

       // public bool IsSkip() => this.CODE == (int)EnumMonoCommonCode.SKIP;

    }



}