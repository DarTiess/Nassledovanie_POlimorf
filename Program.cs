using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nassledovanie_POlimorf
{
    /*  1.	Создать абстрактный класс Издание 
            с методами позволяющим вывести на экран информацию
            об издании, а также определить является ли данное
            издание искомым.*/
    abstract class Publication
    {
        protected string name;
        protected int age;

        public Publication(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract string PubInfo();
        public abstract string Author();
       
    }
    /*1.	Создать абстрактный класс Товар 
с методами, позволяющими вывести на экран информацию о товаре,
а также определить, соответствует ли она искомому типу.*/
abstract class Product
    {
      
        protected string name;
        protected int price;
        protected string production;
        protected int age;

        public Product(string name, int price, string production, int age)
        {
            this.name = name;
            this.price = price;
            this.production = production;
            this.age = age;
        }
        public abstract string ShowProduct();
        public abstract string Type();
    }

    /*1.	Создать абстрактный класс Телефонный_справочник с методами,
позволяющими вывести на экран информацию о записях в телефонном справочнике, 
а также определить соответствие записи критерию поиска.*/
abstract class Phonebook
    {
        protected string name;
        protected string adress;
        protected string numero;
        public Phonebook(string name, string adress, string numero)
        {
            this.name = name;
            this.adress = adress;
            this.numero = numero;
        }
        public abstract string ShowAll();
        public abstract string FindName();
    }
    /*     
            2.	Создать производные классы: Книга (название, 
            фамилия автора, год издания, издательство), 
           */
    class Book : Publication
    {
        string title;
        string author;
   

        public Book(string title, string author, string name, int age) : base(name, age){

            this.title=title;
            this.author = author;
}
        
        public override string PubInfo()
        {
            return "Книга : "+title + ",\n\tАвтор : " + author + ",\n\tИздание : " + name + ",\n\tгод изд.: " + age;
        }
        public override string Author()
        {
            return author;
        }
    }
    /* Статья (название, фамилия автора, 
            название журнала, его номер и год издания), 
            */
    class Article : Publication
    {
        string title;
        string author;
        int number;
        public Article(string title,string author, int number, string name,int age):base(name,age)
        {
            this.title = title;
            this.author = author;
            this.number = number;
        }
        public override string PubInfo()
        {
            return "Журнал : "+title + ",\n\tавтор: " + author+",\n\tномер журнала:  " + number + ",\n\tназвание журнала: " + name+",\n\tгод изд.: " + age;
        }
        public override string Author()
        {
            return author;
        }
    }
    /*Электронный ресурс (название, фамилия автора, 
            ссылка, аннотация) со своими методами вывода 
            информации на экран.*/
   class ElectronicSource:Publication
    {
        string title;
        string author;
        string source;
        string anotation;
         public ElectronicSource(string title, string author, string source, string anotation, string name, int age):base(name,age)
        {
            this.title = title;
            this.author = author;
            this.source = source;
            this.anotation = anotation;

        }
        public override string PubInfo()
        {
            return "Электронный ресурс : " + title + ",\n\tавтор : " + author + ",\n\tссылка : " + source + ",\n\tанотация : " + anotation;
        }
        public override string Author()
        {
            return author;
        }
    }
    /*
2.	Создать производные классы: 
Игрушка (название, цена, производитель, материал, возраст, на который рассчитана),
*/
class Toy : Product
    {
        string type;
        string material;
        public Toy(string name, int price, string production, string material, int age):base(name, price, production, age)
        {
            type = "Игрушка";
            this.material = material;
        }
        public override string ShowProduct()
        {
            return type+ " : Название : " + name + "\n\tцена : " + price + "$\n\tпроизводство : " + production + "\n\tматериал : " + material + "\n\tвозрастные ограничения : +" + age;
        }
        public override string Type()
        {
            return type;
        }
    }
    /*Книга (название, автор, цена, издательство, возраст, на который рассчитана), 

*/
class Books : Product
    {
        string type;
        string author;
        public Books( string name,string author,int price, string production, int age):base( name, price,production, age)
        {
            type = "Книга";
            this.author = author;
        }
        public override string ShowProduct()
        {
            return type + " : Название : " + name + "\n\tавтор : " + author+ "\n\tцена : " + price + "$\n\tиздательство : " + production + "\n\tвозрастные ограничения : +" + age;
        }
        public override string Type()
        {
            return type;
        }
    }
    /*Спорт-инвентарь (название, цена, производитель, возраст, на который рассчитана), 
со своими методами вывода информации на экран, и определения соответствия искомому типу.*/
class SportEquip : Product
    {
        string type;
        public SportEquip(string name, int price, string production, int age):base(name, price, production, age)
        {
            type = "Спорт-инвентарь";
        }
        public override string ShowProduct()
        {
            return type + " : Название : " + name + "\n\tцена : " + price + "$\n\tпроизводство : " + production + "\n\tвозрастные ограничения : +" + age;
        }
        public override string Type()
        {
            return type;
        }
    }
    /*2.	Создать производные классы: Персона (фамилия, адрес, номер телефона), 
   */

class Persone : Phonebook
    {
        string type;
        public Persone(string name, string adress, string numero) : base(name, adress, numero)
        {
           type = "Персона";
        }
        public override string ShowAll()
        {
            return type + " : Фамилия : "+name + "\n\tАдрес : " + adress+ "\n\tНомер телефона : " + numero;
        }
        public override string FindName()
        {
            return name;
        }
    }
    /* Организация (название, адрес, телефон, факс, контактное лицо), 
   */
    class Enterprise : Phonebook
    {
        string type;
        string title;
        string fax;
        public Enterprise(string title, string adress, string numero, string fax, string name):base(name,adress, numero)
        {
            type = "Организация";
            this.title = title;
            this.fax = fax;
        }
        public override string ShowAll()
        {
            return type +": Название : "+title+  "\n\tАдрес : " + adress + "\n\tНомер телефона : " + numero+ "\n\tФакс : " + fax+ "\n\tКонтактное лицо : " + name;
        }
        public override string FindName()
        {
            return name;
        }

    }
    /* Друг (фамилия, адрес, номер телефона, дата рождения) 
    со своими методами вывода информации на экран, и определения соответствия искомому типу.*/
    class Friend : Phonebook
    {
        string type;
        string birthDay;
        public Friend(string name, string adress, string numero, string birthDay):base(name, adress, numero)
        {
            type = "Друг";
            this.birthDay = birthDay;
        }
        public override string ShowAll()
        {
            return type + " : Фамилия : " + name + "\n\tАдрес : " + adress + "\n\tНомер телефона : " + numero+ "\n\tДата рождения : " + birthDay;
        }
        public override string FindName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*Задание 1
    3.	Создать каталог (массив) из n изданий, 
           вывести полную информацию из каталога, а также 
           организовать поиск изданий по фамилии автора.
           */
               Publication[] pub = new Publication[3];
                 pub[0] = new Book("War and Peace", "Tolstoi", "Russian Classic", 1985);
                 pub[1]=new Article("Glamur","Klum", 522, "Elle", 2015);
                 pub[2]= new ElectronicSource("C# pour petits", "Smith", "www.ikdfs.fr", "Le programation pour tres petits et pas de tous ", "FrancoAlliance", 2016);
                 Console.WriteLine(pub[0].PubInfo());
                 Console.WriteLine(pub[1].PubInfo());
                 Console.WriteLine(pub[2].PubInfo());
                 Console.WriteLine();
          
            Console.Write("Для поиска, введите Фамилию Автора ");
            
            string choose = Console.ReadLine();
                 for(int i = 0; i < pub.Length; i++)
                 {
                     if ((choose == pub[i].Author())||(choose==pub[i].Author().ToUpper())||(choose==pub[i].Author().ToLower()))
                     {
                         Console.WriteLine(pub[i].PubInfo());
                     }
                 }
            Console.WriteLine("-------------------------------------------------");
            #endregion

            #region
            /*Задание 7
3.	Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, 
а также организовать поиск товаров определенного типа.
*/

            Product[] prod = new Product[5];
           prod[0] =new Toy("Солдатик",25,"RGEHBNW", "пластмасс",15 );
           prod[1] = new Books("Dictionaire anglais-francais", "Mayer", 105, "Федеральная библиотека", 8);
           prod[2] = new SportEquip("Бита", 20, "RussianEquip", 15);
           prod[3] = new Toy("Неволяшка", 50, "USSR", "plastic", 3);
           prod[4] = new SportEquip("Хокейная клюшка", 250, "LTD Canada", 10);
           foreach(var item in prod)
           {
               Console.WriteLine(item.ShowProduct());
           }
           Console.WriteLine();
           
            Console.WriteLine("Для поиска, введите тип продукта (Игрушка, Книга, либо спорт-инвентарь)");
           string findProd = Console.ReadLine();
           for(int i = 0; i < prod.Length; i++)
           {
               if ((findProd == prod[i].Type().ToLower())||(findProd == prod[i].Type().ToUpper()) ||(findProd== prod[i].Type()))
               {
                   Console.WriteLine(prod[i].ShowProduct());
               }
           }

            Console.WriteLine("-------------------------------------------------");

            #endregion

            #region
            /*Задание 5

3.	Создать базу (массив) из n товаров, 
вывести полную информацию из базы на экран, 
а также организовать поиск в базе по фамилии.
*/
            Phonebook[] number = new Phonebook[6];
            number[0] = new Friend("Watson", "BackerStreet 221B", "254 - 25 - 844","10.10.1985");
            number[1] = new Persone("Hooper", "CrossStreet 47", "247-741-25");
            number[2] = new Enterprise("OON", "Gaagh", "00-01-02-03", "00-01-003", "James");
            number[3] = new Friend("Potter", "Privet Drive 4", "41-74-99", "10.08.1993");
            number[4] = new Persone("EastWood", "WildWest", "002-58-741-6");
            number[5] = new Enterprise("Mail", "Russia, Moscow", "6-524-85", "6-524-8", "Petrov");

            foreach(var item in number)
            {
                Console.WriteLine();
                Console.WriteLine(item.ShowAll());
            }
            Console.WriteLine();
           
            Console.WriteLine("Для поиска, введите Фамилию ");
        
            string findName = Console.ReadLine();
            for(int i = 0; i < number.Length; i++)
            {
                if ((findName == number[i].FindName()) || (findName == number[i].FindName().ToLower()) || (findName == number[i].FindName().ToUpper()))
                {
                    Console.WriteLine(number[i].ShowAll());
                }
            }
            
            #endregion
        }
    }
}
