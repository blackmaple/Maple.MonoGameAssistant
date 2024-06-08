using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.Core
{
    public sealed class MonoRuntimeWebApiService(MonoRuntimeContext runtimeContext) : IDisposable
    {
        MonoRuntimeAttachContext AttachContext { get; } = runtimeContext.CreateAttachContext();
        MonoRuntimeContext RuntimeContext { get; } = runtimeContext;


        #region WebApi
        public MonoImageInfoDTO[] Api_EnumMonoImages()
        {
            return [.. this.RuntimeContext.EnumMonoImages().OrderBy(p => p.Name)];
        }
        public MonoClassInfoDTO[] Api_EnumMonoClasses(PMonoImage pMonoImage)
        {
            return [.. this.RuntimeContext.EnumMonoClasses(pMonoImage).OrderBy(p => p.FullName)];

        }
        public MonoObjectInfoDTO[] Api_EnumMonoObjects(PMonoImage pMonoImage)
        {
            return [.. this.RuntimeContext.EnumMonoObjects(pMonoImage)];
        }
        public MonoClassDetailDTO Api_EnumMonoClassDetail(PMonoClass pMonoClass, EnumMonoFieldOptions fieldOptions)
        {
            return this.RuntimeContext.GetMonoClassDetailDTO(pMonoClass, fieldOptions);
        }

        public void Dispose()
        {
            this.AttachContext.Dispose();
        }
        #endregion

    }
}
