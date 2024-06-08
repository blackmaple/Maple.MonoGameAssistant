namespace Maple.MonoGameAssistant.Model
{
    public class MonoPageResponseDTO
    {
        public int TotalSize { set; get; }
        public int TotalPage { set; get; }
        public int PaegSize { set; get; }
        public int PaegIndex { set; get; }
    }
    public class MonoPageResponseDTO<T_DATA> : MonoPageResponseDTO
    {
        public required T_DATA[] DATAS { set; get; }
    }
}