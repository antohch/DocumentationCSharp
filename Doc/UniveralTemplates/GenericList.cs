using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveralTemplates
{
    internal class GenericList<T>
    {
        private class Node
        {
            private Node? next;
            private Node? data;

            public Node(T t) 
            {
                next = null;
                data = t;
            }
        }
    }
}
