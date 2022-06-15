using Microsoft.StandardUI.Media;
using System;

namespace Microsoft.StandardUI
{
    public class UnintializedHostFramework : IHostFramework
    {
        public static UnintializedHostFramework Instance = new UnintializedHostFramework();

        public IVisualFramework VisualFramework => throw new InvalidOperationException("The Standard UI host framework hasn't been initialized");

        public IStandardUIFactory Factory => throw new InvalidOperationException("The Standard UI host framework hasn't been initialized");
    }
}
