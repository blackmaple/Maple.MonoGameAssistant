using Maple.MonoGameAssistant.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UnityCore
{
    public class TaskStateException(string msg) : MonoCommonException(msg)
    {

        [DoesNotReturn]
        public static void Throw(string msg) => throw new TaskStateException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg) => throw new TaskStateException(msg);

    }


}
