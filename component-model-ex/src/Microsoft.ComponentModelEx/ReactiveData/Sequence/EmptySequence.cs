﻿using System;

namespace Microsoft.ComponentModelEx.ReactiveData.Sequence
{
    public class EmptySequence<T> : IItemsSequence<T>
    {
        public SequenceImmutableArray<T> Items => SequenceImmutableArray<T>.Empty();

        public int ItemCount => 0;
    }
}
