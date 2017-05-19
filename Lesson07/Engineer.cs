using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    class Engineer : Person
    {
        private String skill;

        public Engineer()
        {

        }

        public Engineer(String name, String address, int age, String skill, String telephone)
        {
            Name = name;
            Address = address;
            Age = age;
            Skill = skill;
            Telephone = telephone;
        }

        public override void print()
        {
            Console.WriteLine("氏名:" + Name);
            Console.WriteLine("住所:" + Address);
            Console.WriteLine("年齢:" + Age);
            Console.WriteLine("保有技術:" + Skill);
            Console.WriteLine("電話番号:" + Telephone);
            Console.WriteLine();
        }

        public String Skill
        {
            get { return skill; }
            set { skill = value; }
        }
    }
}
