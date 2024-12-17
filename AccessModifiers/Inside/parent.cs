using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;
namespace Inside;


    public class parent:Grandparent
    {
        protected int ProtectedNumber=30;
        internal int InternalNumber=40;


        public int protectedinternalout{
            get {return protectedinternalout;}
        }
    }
