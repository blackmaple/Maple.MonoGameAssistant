namespace Maple.MonoGameAssistant.WebApi
{
    internal class WebApiPathSettings
    {
        public required string ErrorPage { set; get; }
        public required string[] ApiPaths { get; set; }

        public bool ExistsWebApiPath(PathString pathString)
        {
            return this.ApiPaths.Any(p => pathString.StartsWithSegments(p));
        }
    }
}
