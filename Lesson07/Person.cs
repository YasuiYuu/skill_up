using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    class Person
    {
        private String name;
        private String address;
        private int age;
        private String telephone;

        public Person()
        {
        }

        public Person(String name, String address, int age, String telephone)
        {
            Name = name;
            Address = address;
            Age = age;
            Telephone = telephone;
        }

        public virtual void print()
        {
            Console.WriteLine("氏名:" + Name);
            Console.WriteLine("住所:" + Address);
            Console.WriteLine("年齢:" + Age);
            Console.WriteLine("電話番号:" + Telephone);
            Console.WriteLine();
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
    }
}
