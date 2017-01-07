﻿using Mediator.Net.Binding;
using NUnit.Framework;

namespace Mediator.Net.Autofac.Test
{
    class TestBase
    {
        [TestFixtureTearDown]
        public void Teardown()
        {
            MessageHandlerRegistry.MessageBindings.Clear();
        }
    }
}
