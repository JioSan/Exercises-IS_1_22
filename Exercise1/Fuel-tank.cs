using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Fuel_tank
    {
        private int capacity;
        private int amount;

        public Fuel_tank(int capacity)
        {
            this.capacity = capacity;
        }

        public void Fill(int amount)
        {
            if(amount < 0)
                Console.WriteLine("Ошибка! Отрицательное количество.");
            else if (this.capacity < amount)
                Console.WriteLine("Ошибка! Превышена вместимость бака.");
            else if (this.amount == 0)
                this.amount = amount;
            else
            {
                if ((this.amount + amount) == this.capacity)
                    this.amount = amount;
                else if ((this.amount + amount) > this.capacity)
                    Console.WriteLine("Ошибка! Больше не может быть.");
                else
                    this.amount += amount;
            }
        }
        public int GetAmount()
        {
            return amount;
        }

        public int GetLevel()
        {
            int per, lvl;
            per = capacity / 100;
            lvl = amount / per;
            return lvl;
        }
    }
}
