using Maple.MonoGameAssistant.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UnityCore
{
    public interface IUITaskScheduler<T_GAMECONTEXT> where T_GAMECONTEXT : MonoCollectorContext
    {
        T_GAMECONTEXT GameContext { get; }
        UITaskScheduler Scheduler { get; }

    }
}
