using Microsoft.StandardUI.SourceGenerator.UIFrameworks;

namespace Microsoft.StandardUI.SourceGenerator
{
    public abstract class Output
    {
        public abstract void AddSource(UIFramework? uiFramework, string? childNamespaceName, string fileName, Source source);
    }
}
