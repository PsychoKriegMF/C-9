using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_9
{
    public class Money
    {
        public int Hryvna {  get; set; }
        public int Kopecks {  get; set; }

        public Money(int hryvna, int kopecks)
        {
            Hryvna = hryvna;
            Kopecks = kopecks;
            if(Hryvna < 0 || Kopecks < 0)
            {
                throw new ArgumentException("Деньги не могут быть меньше нуля!");
            }
        }

        public static Money operator+(Money a, Money b)
        {
            int totalKopecks = a.Kopecks + a.Hryvna * 100 + b.Hryvna * 100 + b.Kopecks;
            return new Money(totalKopecks / 100 , totalKopecks % 100);
        }
        public static Money operator -(Money a, Money b)
        {
            int totalKopecks = (a.Kopecks + a.Hryvna * 100) - (b.Hryvna * 100 + b.Kopecks);
            if(totalKopecks < 0)
            {
                throw new BankruptException("Вы банкрот!");
            }
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }
        public static Money operator*(Money a, int multiplier)
        {
            int totalKopecks = (a.Hryvna * 100 + a.Kopecks) * multiplier;
            return new Money(totalKopecks /100, totalKopecks % 100);
        }
        public static Money operator/(Money a, int divisor)
        {
            if(divisor == 0) throw new DivideByZeroException("Делить на ноль нельзя!");
            int totalKopecks = (a.Hryvna * 100 + a.Kopecks);
            return new Money(totalKopecks / divisor / 100, totalKopecks % divisor % 100);
        }
        public static bool operator<(Money a, Money b)
        {
            return a.Hryvna < b.Hryvna || (a.Kopecks == b.Kopecks && a.Kopecks < b.Kopecks); 
        }
        public static bool operator >(Money a, Money b)
        {
            return a.Hryvna > b.Hryvna || (a.Kopecks == b.Kopecks && a.Kopecks > b.Kopecks);
        }
        public static bool operator==(Money a, Money b)
        {
            return a.Kopecks == b.Kopecks && a.Hryvna == b.Hryvna;
        }
        public static bool operator !=(Money a, Money b)
        {
            //return a.Kopecks != b.Kopecks || a.Hryvna != b.Hryvna;
            return !(a == b);
        }

        public static Money operator++(Money a)
        {
            return a + new Money(0, 1);
        }
        public static Money operator --(Money a)
        {
            return a - new Money(0, 1);
        }
        public override string ToString()
        {
            return $"{Hryvna} грн, {Kopecks} коп";
        }
    }
}
