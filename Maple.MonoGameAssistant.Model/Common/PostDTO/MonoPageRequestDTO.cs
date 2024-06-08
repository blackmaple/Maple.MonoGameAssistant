namespace Maple.MonoGameAssistant.Model
{
    public class MonoPageRequestDTO
    {
        public int PageIndex { set; get; }
        public int PageSize { set; get; } = 250;

    }


    public class MonoPageRequestDTO<T> : MonoPageRequestDTO
    {
        public required T Data { set; get; }
    }
}