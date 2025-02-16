using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class CheckTextClass
    {

        protected string TextBox;

        public CheckTextClass(string _TextBox)
        {
            this.TextBox = _TextBox;
        }

        public void CheckSimbol()
        {
            this.TextBox = this.TextBox.Replace(" ", "");
        }

        public string returnTextBox()
        {
            return this.TextBox;
        }
    }
}
