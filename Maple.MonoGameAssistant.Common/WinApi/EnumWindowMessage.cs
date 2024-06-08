namespace Maple.MonoGameAssistant.Common
{
    public enum EnumWindowMessage : uint
    {
        WM_DESTROY = 0x0002,
        WM_QUIT = 0x0012,
        WM_CLOSE = 0x0010,
        WM_KEYDOWN = 0x0100,

        WM_USER = 0x0400,



        USER_IsHungAppWindow = WM_USER + 111,
        USER_QUIT = WM_USER + 222,
        USER_EXEC_CODE = WM_USER + 333
    }
}
