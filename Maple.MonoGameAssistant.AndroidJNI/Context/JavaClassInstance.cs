using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{
    public abstract class JavaClassInstance<TReference>(JOBJECT ptr, TReference reference)
      where TReference : JavaClassReference
    {
        public JOBJECT Instance { get; } = ptr;
        [NotNull]
        public TReference? Reference { get; } = reference;

       

    }
}
