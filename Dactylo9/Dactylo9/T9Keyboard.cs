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
            string[] values = { ",.'?!", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ", " " };

            foreach (var item in values)
            {
                this.Keys.Add(new T9Key(item));
            }

        }

       
    }
}
