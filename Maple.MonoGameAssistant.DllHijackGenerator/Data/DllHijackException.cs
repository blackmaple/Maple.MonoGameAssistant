using Microsoft.CodeAnalysis;
using System;

namespace Maple.MonoGameAssistant.DllHijackGenerator
{
    public class DllHijackException : Exception
    {

        public static readonly DiagnosticDescriptor V1Error =
            new DiagnosticDescriptor(id: "ErrorV1",
            title: "DllHijack",
            messageFormat: "{0}",
            category: "DllHijackException",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor V1Exception =
            new DiagnosticDescriptor(id: "ExceptionV1",
            title: "Exception",
            messageFormat: "{0}",
            category: "Exception",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor V1Info =
            new DiagnosticDescriptor(id: "InfoV1",
            title: "DllHijackException",
            messageFormat: "{0}",
            category: "DllHijackException",
            DiagnosticSeverity.Info,
            isEnabledByDefault: true);


        public DllHijackException() : base() { }

        public DllHijackException(string msg) : base(msg) { }
    }

}
