namespace Maple.MonoGameAssistant.Model
{

    [Obsolete("remove...")]
    public class MonoWebApiToken
    {
        public required string Name { set; get; }
        public required string UID { set; get; }
        public int PID { set; get; }
        public string? Token { set; get; }

        public string? GetSession() => Token;
        public bool Succuss => false == string.IsNullOrEmpty(Token);

        public void CopyTo(MonoWebApiToken webApiToken)
        {
            webApiToken.UID = UID;
            webApiToken.Name = Name;
            webApiToken.PID = PID;
            webApiToken.Token = Token;

        }
    }
}