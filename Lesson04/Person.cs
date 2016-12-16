using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
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
            setName(name);
            setAddress(address);
            setAge(age);
            setTelephone(telephone);
        }

        public void print()
        {
            Console.WriteLine("氏名:" + getName());
            Console.WriteLine("住所:" + getAddress());
            Console.WriteLine("年齢:" + getAge());
            Console.WriteLine("電話番号:" + getTelephone());
            Console.WriteLine();
        }

        public String getName()
        {
            return name;
        }

        public String getAddress()
        {
            return address;
        }

        public int getAge()
        {
            return age;
        }

        public String getTelephone()
        {
            return telephone;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setTelephone(String telephone)
        {
            this.telephone = telephone;
        }
    }
}
