using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
#if SOURCE_GEN
    internal
#else 
    public
#endif
        enum EnumMonoCollectorTypeVersion
    {
        MONO = 0,
        IL2CPP = 1,
        Unity = 2,
        APP = 3,
        Collector = 4,
    }
}
