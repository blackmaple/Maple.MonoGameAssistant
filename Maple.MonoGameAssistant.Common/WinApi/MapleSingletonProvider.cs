namespace Maple.MonoGameAssistant.Common
{
    public class MapleSingletonProvider<T_Singleton> where T_Singleton : class, new()
    {
        public static T_Singleton Instance { get; }

        static MapleSingletonProvider()
        {
            Instance = new T_Singleton();
        }
    }
}
