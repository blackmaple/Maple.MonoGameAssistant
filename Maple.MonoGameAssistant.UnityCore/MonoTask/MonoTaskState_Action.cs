﻿using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal sealed class MonoTaskState_Action<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT> action)
    : MonoTaskState<T_GAMECONTEXT>(gameContext)
    where T_GAMECONTEXT : MonoCollectorContext
    {
        public Action<T_GAMECONTEXT> Action { get; } = action;

        public bool Execute()
        {
            this.Action.Invoke(this.GameContext);
            return true;
        }

    }

}
