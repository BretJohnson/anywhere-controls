﻿using System;

namespace Microsoft.ComponentModelEx.ReactiveData
{
    /// <summary>
    /// A ReactiveVar can be changed by calling Set. The wrapped object should generally be immutable,
    /// not updated directly, though if it is updated directly it's fine to call Set again with the
    /// same object to notify of the change.
    /// </summary>
    /// <typeparam name="TValue">type of the value to wrap</typeparam>
    public sealed class ReactiveVar<TValue> : Reactive<TValue>
    {
        private TValue _value;

        public ReactiveVar(TValue value)
        {
            _value = value;
        }

        public void Set(TValue value)
        {
            _value = value;
            NotifyChanged();
        }

        public override TValue Value {
            get {
                RunningDerivationsStack.Top?.AddDependency(this);
                return _value;
            }
        }
    }
}
