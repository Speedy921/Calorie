using System;
using System.Collections.Generic;
using System.Text;

namespace Calorie
{
    public abstract class Product
    {
        public string Name { get;  }

        /// <summary>
        /// Каллорийность на 100 гр продуката
        /// </summary>

        public int Calorie { get;  }

       /// <summary>
       /// Обьем в граммах на 100 гр продукта
       /// </summary>

        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100.0;
            }
        }



        public Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }
            if (calorie < 0)
            {
                throw new ArgumentException(nameof(Calorie));
            }
            if (volume <= 0)
            {
                throw new ArgumentException(nameof(Volume));
            }

            Name = name;

            Calorie = calorie;

            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}. Калорийность: {Calorie}. Объем {Volume}";
        }
    }
}
