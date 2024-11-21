using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Block
{
    internal class Article //Определить класс Article
    {
        public Person Person; //свойство типа Person, в котором хранятся данные автора статьи;
        public string titel;
        public double rating;

        public Article(Persone persone, string title, double rating) //⦁	конструктор c параметрами типа Person, string, double
        {
            this.persone = persone;
            this.title = title;
            this.rating = rating;

        }

        public Person() //⦁	конструктор без параметров, инициализирующий все свойства класса некоторыми значениями по умолчанию;
        {

            persone = new Persone();
            title = "Time";
            rating = 9.4;
        }


        public string ToFullString() //⦁	метод string ToFullString() для формирования строки со значениями всех свойств класса.
        {

            //return $"статья такая то... рейтинг такой. автор: тут поля из персона";
            return persone.ToFullString() + "  " + title + " " + rating;
        }


    }
}
