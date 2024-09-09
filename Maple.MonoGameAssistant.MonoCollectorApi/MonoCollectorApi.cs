using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoTask;
using Maple.MonoGameAssistant.TaskSchedulerCore;

namespace Maple.MonoGameAssistant.Core
{
    public sealed class MonoCollectorApiService(MonoRuntimeContext runtimeContext, MonoTaskScheduler taskScheduler)
        : IMonoTaskScheduler<MonoRuntimeContext>
    {
        public MonoRuntimeContext GameContext { get; } = runtimeContext;
        public TaskScheduler Scheduler { get; } = taskScheduler;

        public Task<MonoImageInfoDTO[]> EnumMonoImagesAsync()
        {
            return this.MonoTaskAsync(p => p.EnumMonoImages().OrderBy(p => p.Name).ToArray());
        }
        public Task<MonoClassInfoDTO[]> EnumMonoClassesAsync(PMonoImage pMonoImage)
        {
            return this.MonoTaskAsync((p, monoImage) => p.EnumMonoClasses(monoImage).OrderBy(p => p.Name).ToArray(), pMonoImage);
        }
        public Task<MonoObjectInfoDTO[]> EnumMonoObjectsAsync(PMonoImage pMonoImage)
        {
            return this.MonoTaskAsync((p, monoImage) => p.EnumMonoObjects(monoImage).OrderBy(p => p.Name).ToArray(), pMonoImage);


        }
        public Task<MonoClassDetailDTO> EnumMonoClassDetailAsync(PMonoClass pMonoClass, EnumMonoFieldOptions fieldOptions)
        {
            return this.MonoTaskAsync((p, args) => p.GetMonoClassDetailDTO(args.pMonoClass, args.fieldOptions), (pMonoClass, fieldOptions));


        }



    }


}