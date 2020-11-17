using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Monster
    {
        private string name;
        private int power;
        private int health;

        public Monster(string name, int power, int health)
        {
            this.name = name;
            this.power = power;
            this.health = health;
        }
        virtual public void passport()
        {
            Console.WriteLine("Имя:" + name);
            Console.WriteLine("Сила:" + power);
            Console.WriteLine("Здоровье:" + health);
        }
        public int GetHeath()
        {
            return health;
        }
        public string Attack(Monster m)
        {
            int bonus1 = 0;
            int bonus2 = 0;
            if (this is Demon)
                bonus1 = this.power + ((Demon)this).GetBrain() * 10;
            if (m is Demon)
                bonus2 = this.power + ((Demon)this).GetBrain() * 10;
            if (this.power>m.power)
            {
                m.health -= this.power + bonus1;
                return ("Победил" + this.name);
            }
            else 
                if (this.power<m.power)
            {
                this.health -= m.power + bonus2;
                return ("Победил" + m.name);
            }
            else
            {
                return "Ничья";
            }
        }

    }
    class Demon : Monster
    {
        private int brain;

        public Demon(string name, int power, int health, int brain):base(name, power, health)
        {

            this.brain = brain;
        }
        public override void passport()
        {
            base.passport();
            Console.WriteLine("Мозг:" + brain);
        }
                public int GetBrain()
        {
            return brain;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Monster[] Stado = new Monster[4];

            for (int i=0; i<4; i++)
            {
                if (rnd.Next(1) == 0)
                Stado[i] = new Monster("Монстр"+i, rnd.Next(100), rnd.Next(100));
                Stado[i] = new Demon("Демон"+i, rnd.Next(100), rnd.Next(100), rnd.Next(100));
                Stado[i].passport();
            }
            Console.WriteLine("------------------");
            Console.WriteLine("------------------");

            Console.ReadKey();
        }
    }
}
