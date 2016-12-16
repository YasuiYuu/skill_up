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
            setName(name);
            setAddress(address);
            setAge(age);
            setSkill(skill);
            setTelephone(telephone);
        }

        public override void print()
        {
            Console.WriteLine("氏名:" + getName());
            Console.WriteLine("住所:" + getAddress());
            Console.WriteLine("年齢:" + getAge());
            Console.WriteLine("保有技術:" + getSkill());
            Console.WriteLine("電話番号:" + getTelephone());
            Console.WriteLine();
        }

        public String getSkill()
        {
            return skill;
        }

        public void setSkill(String skill)
        {
            this.skill = skill;
        }
    }
}
