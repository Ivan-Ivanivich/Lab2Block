using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Block
{
    internal class Magazine //Определить класс Magazine
    {

        private string name;
        private Frequency frequency;
        private DataSetDateTime Data;
        private int circulation;
        private Arcticle[] arcticles;



    }

    public Magazine(string name, Frequncy frequncy, DateTime date, int circulation, Article[] articles)// конструктор с параметрами типа string, Frequency, DateTime, int 
        {

            this.name = name;
            this.frequncy = frequncy;
            this.date = date;
            this.circulation = circulation;
            this.articles = articles;
        }
        public Magazine()//	конструктор без параметров, инициализирующий поля класса значениями по умолчанию;

        {
            name = "Time";
            date = new DateTime(2002, 02, 20);
            circulation = 10000;
            articles = new Article[0];
        }
        

        //есть вопросы далее
        public void SetName(string value) 
        {
            name = value;
        }
        public string GetName()//   свойство типа string для доступа к полю с названием журнала
        {
            return name;
        }

        public void SetFreqncy(Frequncy value) // свойство типа Frequency для доступа к полю с информацией о периодичности выхода журнала
        {
            frequncy = value;
        }
        public Frequncy GetFreqncy()
        {
            return frequncy;
        }

        public void SetDataTime(DateTime value) // свойство типа DateTime для доступа к полю c датой выхода журнала;
        {
            date = value;
        }
        public DateTime GetDataTime()
        {
            return date;
        }
        
        public void Setcirculation(int value)//свойство типа int для доступа к полю с тиражом журнала; не понятно!!!
        {
            circulation = value;
        }
        public int GetCirculation()
        {
            return circulation;
        }

        public void SetArticles(Article[] value) //свойство типа Article[] для доступа к полю со списком статей
        {
            articles = value;
        }
        public Article[] GetArticles()
        {
            return articles;
        }


        public double GetRating()  //свойство типа double ( только с методом get),
                                   //в котором вычисляется среднее значение рейтинга в списке статей;
        {
            int length = articles.Length;
            double sum = 0;
            for (int a = 0; a < length; a++)
            {
                sum += articles[a].rating;
            }
            sum = sum / articles.Length;

            return sum;
        }


        // разобрать!
        //void AddArticles(params Article[] newArticles) //⦁	метод void AddArticles (params Article[]) для добавления элементов в список статей в журнале;

        //{
        //    //Article[] currentArtickes = new Article[2];
        //    //currentArtickes[0] = new Article();
        //    //currentArtickes[1] = new Article(new Persone(), "", 0);
        //    Article[] tmp;
        //    tmp = new Article[articles.Length + newArticles.Length];
        //    for (int i = 0; i < articles.Length; i++)
        //    {
        //        tmp[i] = articles[i];
        //    }
        //    for (int i = 0; i < newArticles.Length; i++)
        //    {
        //        tmp[articles.Length + i] = newArticles[i];
        //    }
        //    articles = tmp;
        //}

        public string ToFullString()  //⦁	метод string ToFullString() для формирования строки со значениями всех полей класса, включая список статей;

        {
            return GetName() + "  " + GetFreqncy() + " " + GetDataTime() + " " + GetCirculation() + " " + GetArticles();
        }

        public string ToShortString() //⦁	метод string ToShortString(), который формирует строку со значениями всех полей класса без списка статей, но со значением среднего рейтинга статейн.

        {
            return GetName() + "  " + GetFreqncy() + " " + GetDataTime() + " " + GetCirculation() + " " + GetRating();
        }





    }

