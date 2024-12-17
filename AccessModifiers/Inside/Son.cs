using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class Son : parent
    {
        public int  PublicNumber=10;
        private int PrivateNumber=20;

        public int ProtectedOut{
            get {return ProtectedNumber}
        }



    }
}