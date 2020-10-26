using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class CountDownState : IState
    {
        public string DisplayName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
