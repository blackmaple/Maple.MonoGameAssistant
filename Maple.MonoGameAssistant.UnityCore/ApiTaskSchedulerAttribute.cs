namespace Maple.MonoGameAssistant.UnityCore
{

    /// <summary>
    /// 标识API需要调度到哪个TaskScheduler
    /// </summary>
    /// <param name="taskType"></param>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public sealed class ApiTaskSchedulerAttribute(EnumApiTaskSchedulerType taskSchedulerType) : Attribute
    {
        public EnumApiTaskSchedulerType TaskSchedulerType { get; } = taskSchedulerType;

        public ApiTaskSchedulerAttribute() : this(EnumApiTaskSchedulerType.None)
        {
           
        }
    }

    public enum EnumApiTaskSchedulerType
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// CALL MONO API;
        /// CALL GAME METHOD;
        /// allow throw Exception.
        /// </summary>
        MonoTaskScheduler,
        /// <summary>
        /// CALL MONO API;
        /// CALL GAME METHOD;
        /// ACCESS UNITY OBJECT (GAME UI);
        /// disable throw Exception.
        /// </summary>
        UnityTaskScheduler
    }
}
