using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{
    public abstract class JavaClassInstance(JOBJECT ptr)
    {
        public JOBJECT Instance { get; } = ptr;
    }


    public abstract class JavaClassInstance<TReference>(JOBJECT ptr, TReference reference) : JavaClassInstance(ptr)
      where TReference : JavaClassReference
    {
        [NotNull]
        public TReference? Reference { get; } = reference;



    }
}
