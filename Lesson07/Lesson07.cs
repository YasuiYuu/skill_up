using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    class Lesson07
    {
        static void Main(string[] args)
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
                Console.WriteLine("機能一覧	1.追加	2.一覧表示	3.検索	4.終了");
                Console.Write("利用したい機能番号を入力してください(1-4) : ");
                menuno = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (menuno)
                {
                    /**
                     * 追加機能
                     */
                    case 1:
                        Console.WriteLine("クラス一覧	1.Person	2.Employee	3.Engineer	4.キャンセル");
                        Console.Write("情報を追加したいクラス番号を入力してください(1-4) : ");
                        classno = int.Parse(Console.ReadLine());
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
                                age = int.Parse(Console.ReadLine());
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
                                age = int.Parse(Console.ReadLine());
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
                                age = int.Parse(Console.ReadLine());
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
                            if (outdata.getName().StartsWith(sname))
                            {
                                Console.WriteLine(outdata.getName());
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
            Console.WriteLine("処理終了");
        }
    }
}
/*
機能一覧        1.追加  2.一覧表示      3.検索  4.終了
利用したい機能番号を入力してください(1-4) : 2

登録済みのデータを一覧表示
氏名:佐藤太郎
住所:東京都
年齢:20
電話番号:0303123456

氏名:山田花子
年齢:80
所属部署名:所属部署名
電話番号:0170123456

氏名:木村 次郎
住所:京都府
年齢:38
保有技術:保有技術
電話番号:0750123456


機能一覧        1.追加  2.一覧表示      3.検索  4.終了
利用したい機能番号を入力してください(1-4) : 1

クラス一覧      1.Person        2.Employee      3.Engineer      4.キャンセル
情報を追加したいクラス番号を入力してください(1-4) : 3

Engineerクラス追加
氏名を入力してください : name
住所を入力してください : address
年齢を入力してください : 123
保有技術を入力してください : skill
電話番号を入力してください : 123

機能一覧        1.追加  2.一覧表示      3.検索  4.終了
利用したい機能番号を入力してください(1-4) : 2

登録済みのデータを一覧表示
氏名:佐藤太郎
住所:東京都
年齢:20
電話番号:0303123456

氏名:山田花子
年齢:80
所属部署名:所属部署名
電話番号:0170123456

氏名:木村 次郎
住所:京都府
年齢:38
保有技術:保有技術
電話番号:0750123456

氏名:name
住所:address
年齢:123
保有技術:skill
電話番号:123


機能一覧        1.追加  2.一覧表示      3.検索  4.終了
利用したい機能番号を入力してください(1-4) : 3

検索したい氏名を入力してください : 山
山田花子

機能一覧        1.追加  2.一覧表示      3.検索  4.終了
利用したい機能番号を入力してください(1-4) : 4


処理終了
*/
