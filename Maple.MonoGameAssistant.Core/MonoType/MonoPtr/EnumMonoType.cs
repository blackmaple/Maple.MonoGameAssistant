namespace Maple.MonoGameAssistant.Core
{
    public enum EnumMonoType : uint
    {
        /// <summary>
        /// /* End of List */
        /// </summary>
        MONO_TYPE_END = 0x00,
        MONO_TYPE_VOID = 0x01,
        MONO_TYPE_BOOLEAN = 0x02,
        MONO_TYPE_CHAR = 0x03,
        MONO_TYPE_I1 = 0x04,
        MONO_TYPE_U1 = 0x05,
        MONO_TYPE_I2 = 0x06,
        MONO_TYPE_U2 = 0x07,
        MONO_TYPE_I4 = 0x08,
        MONO_TYPE_U4 = 0x09,
        MONO_TYPE_I8 = 0x0a,
        MONO_TYPE_U8 = 0x0b,
        MONO_TYPE_R4 = 0x0c,
        MONO_TYPE_R8 = 0x0d,
        MONO_TYPE_STRING = 0x0e,
        /// <summary>
        /// /* arg: <type> token */
        /// </summary>
        MONO_TYPE_PTR = 0x0f,
        /// <summary>
        /// /* arg: <type> token */
        /// </summary>
        MONO_TYPE_BYREF = 0x10,
        /// <summary>
        /// /* arg: <type> token */
        /// </summary>
        MONO_TYPE_VALUETYPE = 0x11,
        /// <summary>
        /// /* arg: <type> token */
        /// </summary>
        MONO_TYPE_CLASS = 0x12,
        /// <summary>
        /// /* number */
        /// </summary>
        MONO_TYPE_VAR = 0x13,
        /// <summary>
        /// /* type, rank, boundsCount, bound1, loCount, lo1 */
        /// </summary>
        MONO_TYPE_ARRAY = 0x14,
        /// <summary>
        /// /* <type> <type-arg-count> <type-1> \x{2026} <type-n> */
        /// </summary>
        MONO_TYPE_GENERICINST = 0x15,
        MONO_TYPE_TYPEDBYREF = 0x16,
        MONO_TYPE_I = 0x18,
        MONO_TYPE_U = 0x19,
        /// <summary>
        /// /* arg: full method signature */
        /// </summary>
        MONO_TYPE_FNPTR = 0x1b,
        MONO_TYPE_OBJECT = 0x1c,
        /// <summary>
        /// /* 0-based one-dim-array */
        /// </summary>
        MONO_TYPE_SZARRAY = 0x1d,
        /// <summary>
        /// /* number */
        /// </summary>
        MONO_TYPE_MVAR = 0x1e,
        /// <summary>
        /// /* arg: typedef or typeref token */
        /// </summary>
        MONO_TYPE_CMOD_REQD = 0x1f,
        /// <summary>
        /// /* optional arg: typedef or typref token */
        /// </summary>
        MONO_TYPE_CMOD_OPT = 0x20,
        /// <summary>
        /// /* CLR internal type */
        /// </summary>
        MONO_TYPE_INTERNAL = 0x21,
        /// <summary>
        /// /* Or with the following types */
        /// </summary>
        MONO_TYPE_MODIFIER = 0x40,
        /// <summary>
        /// /* Sentinel for varargs method signature */
        /// </summary>
        MONO_TYPE_SENTINEL = 0x41,
        /// <summary>
        /// /* Local var that points to pinned object */
        /// </summary>
        MONO_TYPE_PINNED = 0x45,
        /// <summary>
        /// /* an enumeration */
        /// </summary>
        MONO_TYPE_ENUM = 0x55
    }
}
