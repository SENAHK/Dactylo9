using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Dactylo9
{
    public class T9Keyboard
    {
        private List<T9Key> _allKeys = new List<T9Key>();

        public List<T9Key> Keys
        {
            get { return _allKeys; }
            set { _allKeys = value; }
        }

        public T9Keyboard()
        {
            string[] values = { ",.?!1", "ABC2", "DEF3", "GHI4", "JKL5", "MNO6", "PQRS7", "TUV8", "WXYZ9", " " };

            foreach (var item in values)
            {
                this.Keys.Add(new T9Key(item));
            }

        }

       
    }
}
