using Microsoft.CodeAnalysis;

namespace StronglyTypedId.Diagnostics
{
    internal static class InvalidBackingTypeDiagnostic
    {
        internal const string Id = "STI4";
        internal const string Message = "The StronglyTypedIdBackingType value provided is not a valid combination of flags";
        internal const string Title = "Invalid backing type";

        public static Diagnostic Create(SyntaxNode currentNode) =>
            Diagnostic.Create(
                new DiagnosticDescriptor(
                    Id, Title, Message, category: Constants.Usage, defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true),
                currentNode.GetLocation());
    }
}