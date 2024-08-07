using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoGameSettings
    {
        /// <summary>
        /// 游戏名 游戏内赋值
        /// </summary>
        public string? GameName { set; get; }
        /// <summary>
        /// Url 游戏内赋值
        /// </summary>
        public string? BaseAddress { set; get; }

        /// <summary>
        /// 游戏路径 游戏内赋值
        /// </summary>
        public string? GamePath { set; get; }

        /// <summary>
        /// Web资源路径 游戏内赋值
        /// </summary>
        public string? WebRootPath { set; get; }

        /// <summary>
        /// MonoDataCollector WEBAPI 
        /// </summary>
        public bool MonoDataCollector { set; get; }

        /// <summary>
        /// 管道
        /// </summary>
        public bool NamedPipe { set; get; }

        /// <summary>
        /// HTTP
        /// </summary>
        public bool Http { set; get; }

        /// <summary>
        /// 指定HTTP端口(>=1024) 若端口已被占用或无效 则随机一个
        /// </summary>
        public int Port { set; get; }

        /// <summary>
        /// 运行并打开Url
        /// </summary>
        public bool AutoOpenUrl { set; get; }
        /// <summary>
        /// 打开的HTML页面 
        /// </summary>
        public string? IndexPage { set; get; }
        /// <summary>
        /// 游戏资源文件夹
        /// </summary>
        public string? GameResource { set; get; }


        public string? QQ { set; get; }
        public bool TryGetRandomPort(out int port)
        {
            port = this.Port;
            var allPorts = GetActivePotrs().ToArray();

            if (port >= 1024 && !allPorts.Contains(port))
            {
                return true;
            }
            var availablePorts = Enumerable.Range(1024, 65535 - 1024).Except(allPorts).ToArray();
            if (availablePorts.Length == 0)
            {
                return false;
            }
            Random.Shared.Shuffle(availablePorts);
            port = availablePorts[0];
            return true;

            static IEnumerable<int> GetActivePotrs()
            {
                var ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                foreach (var tcp in ipGlobalProperties.GetActiveTcpListeners())
                {
                    yield return tcp.Port;
                }
                foreach (var udp in ipGlobalProperties.GetActiveUdpListeners())
                {
                    yield return udp.Port;
                }
                foreach (var tcpConnection in ipGlobalProperties.GetActiveTcpConnections())
                {
                    yield return tcpConnection.LocalEndPoint.Port;
                }


            }
        }


        public bool TryGetOpenUrl([MaybeNullWhen(false)] out string openUrl, bool force = false)
        {
            Unsafe.SkipInit(out openUrl);
            if ((force == false && this.AutoOpenUrl == false) || string.IsNullOrEmpty(this.BaseAddress))
            {
                return false;
            }
            openUrl = $"{this.BaseAddress}{this.IndexPage ?? "index.html"}";
            return true;
        }


        public string? WriteImageFile(ReadOnlySpan<byte> datas, string category, string fileName, bool convertUrl = false)
        {

            if (string.IsNullOrEmpty(this.WebRootPath))
            {
                return default;
            }

            var gameResource = Path.Combine(this.WebRootPath, this.GameResource ?? "GameResource");
            if (false == Directory.Exists(gameResource))
            {
                Directory.CreateDirectory(gameResource);
            }
            var categoryPath = Path.Combine(gameResource, category);
            if (false == Directory.Exists(categoryPath))
            {
                Directory.CreateDirectory(categoryPath);
            }

            var fullFileName = Path.Combine(categoryPath, fileName);
            using (var fileStream = File.Open(fullFileName, FileMode.Create))
            {
                fileStream.Write(datas);
            }

            return convertUrl ? ConvertLocal2Url(this.WebRootPath, fullFileName) : fullFileName;

        }
        public bool TryGetJsonStream(string fileName, [MaybeNullWhen(false)] out Stream stream)
        {
            Unsafe.SkipInit(out stream);
            if (string.IsNullOrEmpty(this.WebRootPath))
            {
                return false;
            }

            var gameResource = Path.Combine(this.WebRootPath, this.GameResource ?? "GameResource");
            if (false == Directory.Exists(gameResource))
            {
                Directory.CreateDirectory(gameResource);
            }


            var fullFileName = Path.Combine(gameResource, fileName);
            stream = File.Open(fullFileName, FileMode.Create);
            return true;



        }

        public bool TryGetGameResourceUrl(string category, string fileName, [MaybeNullWhen(false)] out string url)
        {
            Unsafe.SkipInit(out url);
            if (string.IsNullOrEmpty(this.WebRootPath))
            {
                return false;
            }

            var gameResource = Path.Combine(this.WebRootPath, this.GameResource ?? "GameResource");
            if (false == Directory.Exists(gameResource))
            {
                return false;
            }
            var categoryPath = Path.Combine(gameResource, category);
            if (false == Directory.Exists(categoryPath))
            {
                return false;
            }
            var fullFileName = Path.Combine(categoryPath, fileName);
            if (false == File.Exists(fullFileName))
            {
                return false;
            }
            url = ConvertLocal2Url2(this.WebRootPath, fullFileName);
            return true;
        }

        public string? GetGameDefaultPngUrl()
        {
            if (TryGetGameResourceUrl("DefaultIcon", "favicon.png", out var url))
            {
                return url;
            }
            return default;
        }

        static string ConvertLocal2Url(string rootPath, string localFullFile)
        {

            return localFullFile.Replace(rootPath, "").Replace(@"\", @"/");
        }
        string ConvertLocal2Url2(string rootPath, string localFullFile)
        {

            return localFullFile.Replace(rootPath, this.BaseAddress).Replace(@"\", @"/");
        }

        public GameSessionInfoDTO GetGameSessionInfo(string? ver = default)
        {
            return new GameSessionInfoDTO()
            {
                DisplayImage = this.GetGameDefaultPngUrl(),
                ObjectId = Environment.ProcessId.ToString(),
                DisplayName = this.GameName,
                DisplayDesc = string.Empty,
                ApiVer = ver,
                QQ = this.QQ,
            };
        }
    }
}
