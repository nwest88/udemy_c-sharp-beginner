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

        public String getMiddle()
        {
            return middle;
        }

        public void setMiddle(String mname)
        {
            middle = mname;
        }

        public void setName(String fname, String mname, String lname)
        {
            first = fname;
            middle = mname;
            last = lname;
        }

        public String Middle
        {
            get
            {
                return middle;
            }
            set
            {
                middle = value;
            }
        }

        public String Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
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

        public String getLastFirst()
        {
            return last + ", " + first + " " + middle;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Name aName = new Name("Jane", "Micah", "Smith");
            Console.WriteLine(aName.ToString());
            aName.Middle = "Mary";
            Console.WriteLine(aName.getLastFirst());
            Console.WriteLine("Her middle name is " + aName.Middle);
            aName.Last = "Brown";
            Console.WriteLine(aName.First + " " + aName.Middle + " "
                + aName.Last);
            Console.ReadKey();
        }
    }
}
