using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Properties.models
{
    public class Type
    {
        public readonly string TypeID;
        public readonly string TypeName = "Online";

        public Type(string typeID)
        {
            TypeID = typeID;
        }
    }
}