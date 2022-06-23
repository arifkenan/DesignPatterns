using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatterns.Lab3
{
    class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;
        private Component3 _component3;

        public ConcreteMediator(Component1 component1, Component2 component2, Component3 component3)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
            this._component3 = component3;
            this._component3.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            
        }
    }
}
