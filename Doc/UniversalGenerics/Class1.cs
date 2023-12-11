using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalGenerics
{
    class NodeClass
    {
        private string _txt;

        private NodeClass? next;
        internal string _Txt 
        {
            get { return _txt; }
            set { _txt = value; }
        }

        public NodeClass? Next
        {
            get { return next; }
            set { next = value; }
        }

        public NodeClass(string txt)
        {
            next = null;
            _txt = txt;
        }
    }
    internal class Class1
    {
        private NodeClass? head;
        public Class1()
        {
            head = null;
        }
        public void Add(string text)
        {
            NodeClass n = new NodeClass(text);
            n.Next = head;
            head = n;
        }
        public IEnumerator<string> GetEnumerator()
        {
            NodeClass? current = head;
            while(current != null)
            {
                yield return current._Txt;
                current = current.Next;
            }
        }
    }
}
