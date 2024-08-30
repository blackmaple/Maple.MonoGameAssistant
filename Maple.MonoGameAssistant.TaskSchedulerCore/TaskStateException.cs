using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.TaskSchedulerCore
{
    public class TaskStateException(string msg) : MonoCommonException(msg)
    {

        [DoesNotReturn]
        public static void Throw(string msg) => throw new TaskStateException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg) => throw new TaskStateException(msg);

    }
}
