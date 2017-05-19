using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    class Employee : Person
    {
        private String section;

        public Employee()
        {
        }

        public Employee(String name, int age, String section, String telephone)
        {

            Name = name;
            Age = age;
            Section = section;
            Telephone = telephone;
        }

        public override void print()
        {
            Console.WriteLine("氏名:" + Name);
            Console.WriteLine("年齢:" + Age);
            Console.WriteLine("所属部署名:" + Section);
            Console.WriteLine("電話番号:" + Telephone);
            Console.WriteLine();
        }

        public String Section
        {
            get { return section; }
            set { section = value; }
        }
    }
}
