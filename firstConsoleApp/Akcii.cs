using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstConsoleApp
{
    public class Stocks
    {
        private readonly string _company;
        private long _stoks_number;
        private double _stoks_price;
        private double _total_value;

        public Stocks(string company, long stoks_number, double stoks_price) 
        {
            _company = company;
            _stoks_number = stoks_number;
            _stoks_price = stoks_price;
            _total_value = count_total();
            Console.WriteLine($"Начальный пакет акций {stoks_number} по цене {stoks_price}");
        }
        public void show() 
        {
            Console.WriteLine();
            Console.WriteLine($"Компания {_company}");
            Console.WriteLine($"Кол-во акций {_stoks_number}");
            Console.WriteLine($"Цена акции {_stoks_price}");
            Console.WriteLine($"Стоимость всего пакета {_total_value}");
        }
        private double count_total() 
        {
            return _stoks_price*_stoks_number;
        }
        public void sell(long num, double price) 
        {
            if (num <= _stoks_number & price <= _stoks_price) 
            {
                _total_value -= num * price;
                Console.WriteLine($"Продажа пакета ({num} акций по цене {price}). {_company}");
            }
            else if (num < _stoks_number) { Console.WriteLine("Не хватает акций"); }
        }
        public void buy(long num, double price) 
        {
            Console.WriteLine($"Покупка доп. пакета ({num} акций по цене {price}). {_company}");
            _stoks_number += num;
            _stoks_price = price;
            _total_value = count_total();
        }
    }
}
