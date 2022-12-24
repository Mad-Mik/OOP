using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ParentClass
    {
        int a;
        public int b;
        private int c;
        protected int d = 123;
        internal int e;

        public int MethodPublic(int x)
        {
            ChildClass objChild = new ChildClass();
            return 0;
        }

        void MethodDefault()
        {

        }

        private void MethodPrivate()
        {

        }

    }
}
