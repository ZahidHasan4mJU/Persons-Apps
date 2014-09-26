using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Persons
    {
        public string fName;
        public string mName;
        public string lName;

        public string getFullName()
        {
            return fName + "  " + mName + "  " + lName;
        }

        public string getReverseName()
        {
            string fullname = getFullName();
            char[] array = fullname.ToCharArray();
            string reverseName = "";
            for (int i = array.Length - 1; i > -1; i--)
            {
                reverseName += array[i];
                
            }
            return reverseName;

        }
        
    }
}
