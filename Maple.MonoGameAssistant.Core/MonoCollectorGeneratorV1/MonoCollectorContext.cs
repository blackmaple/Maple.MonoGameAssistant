using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Core
{

    [method: MonoCollectorFlag(EnumMonoCollectorFlag.ContextCtor)]
    public abstract class MonoCollectorContext(MonoRuntimeContext runtimeContext, EnumMonoCollectorTypeVersion typeVersion, ILogger logger)
    {
        public EnumMonoCollectorTypeVersion BuildVersion { get; } = typeVersion;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public ILogger Logger { get; } = logger;

        internal MonoImageInfoDTO[] ImageInfoDTOs { get; } = [.. runtimeContext.EnumMonoImages()];

 
        [MonoCollectorFlag(EnumMonoCollectorFlag.GetClassInfo)]
        protected MonoCollectorClassInfo GetClassInfo(MonoCollecotrClassSettings classSettings)
        {
            if (this.ImageInfoDTOs.TryGetFirstImageInfo(classSettings.Utf8ImageName, out var imageInfoDTO) == false)
            {
                var errMsg = $"NOT FOUND {classSettings.ImageName}";
                this.Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoCollectorClassInfo>(errMsg);
            }
            if (this.RuntimeContext.TryGetFirstClassInfo(imageInfoDTO, classSettings, out var classInfo) == false)
            {
                var errMsg = $"NOT FOUND [{classSettings.ImageName}].[{classSettings.Namespace}.{classSettings.ClassName}]";
                this.Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoCollectorClassInfo>(errMsg);
            }

            return classInfo;
        }

        public PMonoString T(string str) => this.RuntimeContext.GetMonoString(str);
        public PMonoString T(in ReadOnlySpan<char> str) => this.RuntimeContext.GetMonoString(str);


        [MonoCollectorFlag(EnumMonoCollectorFlag.Throw)]
        [DoesNotReturn]
        public static TContext ThrowIfVerNotFound<TContext>(EnumMonoCollectorTypeVersion typeVersion)
            where TContext : MonoCollectorContext
        {

            var errMsg = $"NOT FOUND VER:{typeVersion}";
            return MonoCollectorObjectException.Throw<TContext>(errMsg);
        }

    }
}
