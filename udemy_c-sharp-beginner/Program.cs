using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace udemy_c_sharp_beginner
{
    class Name
    {
        private String first, middle, last;

        public Name(String fname, String mname, String lname)
        {
            first = fname;
            middle = mname;
            last = lname;
        }

        public override String ToString()
        {
            return first + " " + middle + " " + last;
        }

        // get and set methods

        public String getLast()
        {
            return last;
        }

        public String getFirst()
        {
            return first;
        }

        public void setFirst(String fname)
        {
            first = fname;
        }

        public void setLast(String lname)
        {
            last = lname;
        }

        public void setName(String fname, String mname, String lname)
        {
            first = fname;
            middle = mname;
            last = lname;
        }

        public String First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public String getInitials()
        {
            return first.Substring(0, 1) + middle.Substring(0, 1)
                + last.Substring(0, 1);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Name myName = new Name("John", "Q", "Public");
            Console.WriteLine(myName.getInitials());
            Console.ReadKey();
        }
    }
}
