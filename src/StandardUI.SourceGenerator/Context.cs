using Microsoft.CodeAnalysis;

namespace Microsoft.StandardUI.SourceGenerator
{
    public class Context
    {
        public int IndentSize { get; } = 4;
        public Compilation Compilation { get; }
        public Output Output { get; }

        public Context(Compilation compilation, Output outputLocation)
        {
            Compilation = compilation;
            Output = outputLocation;
        }
    }
}
