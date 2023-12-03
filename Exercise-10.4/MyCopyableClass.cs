using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercise_10._4
{
    class MyCopyableClass
    {
        protected int myInt;
        public int ContainedInt
        {
            get
            { return myInt; }
            set
            { myInt = value; }
        }
        public MyCopyableClass GetCopy() => (MyCopyableClass)MemberwiseClone();
    }
}
