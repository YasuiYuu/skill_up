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
            setName(name);
            setAge(age);
            setSection(section);
            setTelephone(telephone);
        }

        public override void print()
        {
            Console.WriteLine("氏名:" + getName());
            Console.WriteLine("年齢:" + getAge());
            Console.WriteLine("所属部署名:" + getSection());
            Console.WriteLine("電話番号:" + getTelephone());
            Console.WriteLine();
        }

        public String getSection()
        {
            return section;
        }

        public void setSection(String section)
        {
            this.section = section;
        }
    }
}
