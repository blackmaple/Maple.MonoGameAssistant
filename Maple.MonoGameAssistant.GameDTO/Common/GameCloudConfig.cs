using System.Text;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCloudConfig
    {
        public required string GameApiUrl { set; get; }


        public static string ToCode(string url)
        {
            var buffer = Encoding.UTF8.GetBytes(url);
            return Convert.ToHexString(buffer);
        }
        public static string FromCode(string hex)
        {
            var buffer = Convert.FromHexString(hex);
            return Encoding.UTF8.GetString(buffer);
        }

    }
}