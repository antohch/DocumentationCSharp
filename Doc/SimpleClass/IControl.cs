using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    interface IControl
    {
        void Paint();
    }
    interface ITextBox : IControl
    {
        void SetText(string text);
    }
    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }
    interface IComboBox : ITextBox, IListBox { }
    interface IDataBound
    {
        void Bind(Binder binder);
    }

    public class EditBox : IControl, IDataBound
    {
        public void Bind(Binder binder)
        {
            //throw new NotImplementedException();
        }

        public void Paint()
        {
            //throw new NotImplementedException();
        }
    }
}
