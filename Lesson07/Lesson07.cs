using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Lesson07
{
    class Lesson07
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList indata = new ArrayList();
                Person person = new Person("佐藤太郎", "東京都", 20, "0303123456");
                Person employee = new Employee("山田花子", 80, "所属部署名", "0170123456");
                Person engineer = new Engineer("木村 次郎", "京都府", 38, "保有技術", "0750123456");
                indata.Add(person);
                indata.Add(employee);
                indata.Add(engineer);

                int menuno;
                int classno;

                String name;
                String address;
                int age;
                String telephone;
                String section;
                String skill;
                String sname;
                int cnt;

                do
                {
                    Console.WriteLine("機能一覧  1.追加  2.一覧表示  3.検索  4.終了");
                    Console.Write("利用したい機能番号を入力してください(1-4) : ");
                    menuno = int.Parse(Microsoft.VisualBasic.Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow));
                    if (menuno < 1 || 4 < menuno)
                    {
                        throw new MyException("範囲外の数値が入力されています。");
                    }
                    Console.WriteLine();
                    switch (menuno)
                    {
                        /**
                         * 追加機能
                         */
                        case 1:
                            Console.WriteLine("クラス一覧  1.Person  2.Employee  3.Engineer  4.キャンセル");
                            Console.Write("情報を追加したいクラス番号を入力してください(1-4) : ");
                            classno = int.Parse(Microsoft.VisualBasic.Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow));
                            if (classno < 1 || 4 < classno)
                            {
                                throw new MyException("範囲外の数値が入力されています");
                            }
                            Console.WriteLine();
                            switch (classno)
                            {
                                /**
                                 * Personクラス追加
                                 */
                                case 1:
                                    Console.WriteLine("Personクラス追加");
                                    Console.Write("氏名を入力してください : ");
                                    name = Console.ReadLine();
                                    Console.Write("住所を入力してください : ");
                                    address = Console.ReadLine();
                                    Console.Write("年齢を入力してください : ");
                                    age = int.Parse(Microsoft.VisualBasic.Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow));
                                    Console.Write("電話番号を入力してください : ");
                                    telephone = Console.ReadLine();
                                    Person cperson = new Person(name, address, age, telephone);
                                    indata.Add(cperson);
                                    break;
                                /**
                                 * Employeeクラス追加
                                 */
                                case 2:
                                    Console.WriteLine("Employeeクラス追加");
                                    Console.Write("氏名を入力してください : ");
                                    name = Console.ReadLine();
                                    Console.Write("年齢を入力してください : ");
                                    age = int.Parse(Microsoft.VisualBasic.Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow));
                                    Console.Write("所属部署名を入力してください : ");
                                    section = Console.ReadLine();
                                    Console.Write("電話番号を入力してください : ");
                                    telephone = Console.ReadLine();
                                    Person cemployee = new Employee(name, age, section, telephone);
                                    indata.Add(cemployee);
                                    break;
                                /**
                                 * Engineerクラス追加
                                 */
                                case 3:
                                    Console.WriteLine("Engineerクラス追加");
                                    Console.Write("氏名を入力してください : ");
                                    name = Console.ReadLine();
                                    Console.Write("住所を入力してください : ");
                                    address = Console.ReadLine();
                                    Console.Write("年齢を入力してください : ");
                                    age = int.Parse(Microsoft.VisualBasic.Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow));
                                    Console.Write("保有技術を入力してください : ");
                                    skill = Console.ReadLine();
                                    Console.Write("電話番号を入力してください : ");
                                    telephone = Console.ReadLine();
                                    Person cengineer = new Engineer(name, address, age, skill, telephone);
                                    indata.Add(cengineer);
                                    break;
                                case 4:
                                    Console.WriteLine("キャンセルしました");
                                    break;
                            }
                            break;
                        /**
                         * 一覧表示機能
                         */
                        case 2:
                            Console.WriteLine("登録済みのデータを一覧表示");
                            foreach (Person outdata in indata)
                            {
                                outdata.print();
                            }
                            break;
                        /**
                         * 検索機能
                         */
                        case 3:
                            Console.Write("検索したい氏名を入力してください : ");
                            sname = Console.ReadLine();
                            cnt = 0;
                            foreach (Person outdata in indata)
                            {
                                if (outdata.Name.StartsWith(sname))
                                {
                                    Console.WriteLine(outdata.Name);
                                    cnt++;
                                }
                            }
                            if (cnt == 0)
                            {
                                Console.WriteLine("一致するデータはありませんでした");
                            }
                            break;
                        case 4:
                            break;
                    }
                    Console.WriteLine();
                } while (menuno != 4);
                Console.WriteLine("処理を終了しました。");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Error : " + e.Message);
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Main(args);
            }
        }
    }
}