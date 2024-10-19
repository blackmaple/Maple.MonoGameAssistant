using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidModel
{
    public class AndroidCommonException([CallerMemberName] string msg = nameof(AndroidCommonException))
    : Exception(msg)
    {



    }
}
