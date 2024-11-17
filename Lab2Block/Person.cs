using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Block
{
    internal class Person
    {
        private string name;
        private string surname;
        private DateTime dataofbirth;

        public Person(string name, string surname, DateTime dataofbirth) //имя совпадает с названием класса
        {
            this.name = name;
            this.surname = surname;
            this.dataofbirth = dataofbirth;

        }
       public Person()
        {
            Console.WriteLine("Создание объекта Person");
            name = "Vasia";
            surname = "Pupkin";
            //dataofbirth = new DateTime(int 2002, int 12, int 21)
            dataofbirth = new DateTime( 2002,  12,  21);

        }
        //[модификаторы]
        //тип_свойства название_свойства
        //{
        //    get { действия, выполняемые при получении значения свойства}
        //    set { действия, выполняемые при установке значения свойства}
        //}

        public void SetName(string value)
        {
            name = value;
        }
        public string GetName()
        {
            return name;
        }
        public void Setsurname(string value)
        {
            surname = value;
        }
        public string Getsurname()  // типа
        {
            return surname;
        }
        public void Setdataofbirth(DateTime value)
        {
            dataofbirth = value; 
        }


        public DateTime Getdataofbirth() // типа но нет  свойство типа DateTime для доступа к полю с датой рождения;
        {
            return dataofbirth;
        }

        public string ToFullString() //метод string ToFullString() для формирования строки со значениями всех полей класса;
        {
            return GetName() + " " + Getsurname() + " " + Getdataofbirth();
        }

        public string ToShortString() //метод string ToShortString(), который возвращает строку, содержащую только имя и фамилию.
        {  
            return GetName() + " " + Getsurname()
        }


         

    }
}
