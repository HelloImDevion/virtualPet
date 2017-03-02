using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class Pet
    {
        private int eat;

        private int fly;

        private int sleep;

        private int train;

        private int play;

        public Pet()

        {
           

        }

        public Pet(int Eat, int fly, int sleep, int train, int play)
        {
            this.eat = eat;
            this.fly = fly;
            this.sleep = sleep;
            this.train = train;
            this.play = play;


        }

        public int Eat
        {
            get { return this.eat; }
            set { eat = value; }
        }

        public int Fly
        {
            get { return this.fly; }
            set { fly = value; }
        }

        public int Sleep
        {
            get { return this.sleep; }
            set { sleep = value; }
        }

        public int Train
        {
            get { return this.train; }
            set { train = value; }
        }

        public int Play
        {
            get { return this.play; }
            set { play = value; }
            
        }

        static int Play()
        {
            Console.WriteLine("Your dragon is playing");
        } 

        static int Train()
        {
            Console.WriteLine("Your dragon is stronger!");
        }

        static int Sleep()
        {
            Console.WriteLine("Shhhhhh! your dragon is sleep. ");
        }


    }
}
