﻿namespace Maple.MonoGameAssistant.Windows.HotKey
{
    public struct WinMsgNotifyDTO
    {

        public uint Msg { set; get; }
        public nint WParam { set; get; }
        public readonly EnumVirtualKeyCode KeyCode => (EnumVirtualKeyCode)WParam;
        public nint LParam { set; get; }

    }
}
