using System;

namespace OPSuperHeros
{
    class Program
    {
        class Player
        {
            string name;
            int hp;
            //constructor
            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }
            public void SayHello()
            {
                Console.WriteLine($"{name} says Hello!");
            }
            public void ShowYourHP()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }
            public int MakeDamege()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            } 
            public void TakeDamage(int damage)
            {
                if(hp <= 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = hp - damage;
                }
            }
            public int HP
            {
                get { return hp; }
            }
            public string Name
            {
                get { return name; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name your first character:");
            string characternameone = Console.ReadLine();
            Console.WriteLine("Name your second character:");
            string characternametwo = Console.ReadLine();
            Player playerone = new Player(characternameone);
            Player playertwo = new Player(characternametwo);
            playerone.SayHello();
            playerone.ShowYourHP();
            playertwo.SayHello();
            playertwo.ShowYourHP();
            for(int i = 0; i < 3; i++)
            {
                playerone.TakeDamage(playertwo.MakeDamege());
                playertwo.TakeDamage(playerone.MakeDamege());
                playerone.ShowYourHP();
                playertwo.ShowYourHP();
            }
            if(playerone.HP > playertwo.HP)
            {
                Console.WriteLine($"{playerone.Name} won!");
            }else if(playerone.HP < playertwo.HP)
            {
                Console.WriteLine($"{playertwo.Name} won!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
