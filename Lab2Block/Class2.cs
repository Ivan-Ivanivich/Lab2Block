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

    public Magazine(string name, Frequncy frequncy, DateTime date, int circulation, Article[] articles)//⦁	конструктор с параметрами типа string, Frequency, DateTime, int 
        {

            this.name = name;
            this.frequncy = frequncy;
            this.date = date;
            this.circulation = circulation;
            this.articles = articles;
        }
        public Magazine()//⦁	конструктор без параметров, инициализирующий поля класса значениями по умолчанию;

        {
            name = "Time";
            date = new DateTime(2002, 02, 20);
            circulation = 10000;
            articles = new Article[0];
        }

    }
