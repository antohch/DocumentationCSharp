using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseClass
{
    public class BaseClass
    {
        public void DoWork() { WorkField++; }
        public int WorkField;
        public int WorkProperty
        {
            get { return 0; }
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void DoWork() { WorkField++; }
        public new int WorkField;
        public new int WorkProperty
        {
            get { return 0; }
        }
    }

    public class A
    {
        public virtual void DoWork() { }
    }
    public class B : A
    {
        public override void DoWork() { }
    }
    public class C : B
    {
        public sealed override void DoWork() { }
    }
    public class D : C
    {
        public new void DoWork() { }
    }

    public class Base
    {
        public virtual void DoWork() { }
    }
    public class Derived : Base
    {
        public override void DoWork() 
        { 
            base.DoWork();
        }
    }
}
