using Microsoft.CodeAnalysis;
using System;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    internal class MonoCollectorGeneratorV2Exception : Exception
    {

        public static readonly DiagnosticDescriptor V2Error =
            new DiagnosticDescriptor(id: "ErrorV2",
            title: "MonoCollectorGeneratorV2Exception",
            messageFormat: "{0}",
            category: "MonoCollectorGeneratorV2Exception",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor V2Exception =
            new DiagnosticDescriptor(id: "ExceptionV2",
            title: "Exception",
            messageFormat: "{0}",
            category: "Exception",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor V2Info =
            new DiagnosticDescriptor(id: "InfoV2",
            title: "MonoCollectorGeneratorV2",
            messageFormat: "{0}",
            category: "MonoCollectorGeneratorV2",
            DiagnosticSeverity.Info,
            isEnabledByDefault: true);


        public MonoCollectorGeneratorV2Exception() : base() { }

        public MonoCollectorGeneratorV2Exception(string msg) : base(msg) { }
    }
}
