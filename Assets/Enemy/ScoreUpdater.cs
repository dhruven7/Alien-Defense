using System;

public class ScoreUpdater
{
    public IScoreUpdater enemy1;
    public IScoreUpdater enemy2;
    public IScoreUpdater enemy3;
    public IScoreUpdater enemy4;

    public ScoreUpdater()
    {
        enemy1 = new EasyA();
        enemy2 = new EasyB();
        enemy3 = new HardA();
        enemy4 = new HardB();

        enemy3.setSuccessor(enemy4);
        enemy2.setSuccessor(enemy3);
        enemy1.setSuccessor(enemy2);        

    }

    public int invoke(String enemy)
    {
        return 
            enemy1.incrementScore(enemy);
    }
}

//namespace COR_Game
//{
//    class MainApp
//    {
//        static void Main()
//        {
//            ScoreUpdater aa = new EasyA();
//            ScoreUpdater ba = new EasyB();
//            ScoreUpdater ca = new HardA();
//            ScoreUpdater da = new HardB();

//            aa.SetSuccessor(ba);
//            ba.SetSuccessor(ca);
//            ca.SetSuccessor(da);


//            //750
//            Enemy e = new Enemy("HardA");
//            aa.IncrementScore(e);
            
//            //500
//            e = new Enemy("EasyB");
//            aa.IncrementScore(e);
            
//            //1000
//            e = new Enemy("HardB");
//            aa.IncrementScore(e);
            
//            //250
//            e = new Enemy("EasyA");
//            aa.IncrementScore(e);
//            //Nothing
//            e = new Enemy("Foo");
//            aa.IncrementScore(e);

//            Console.ReadKey();
//        }
//    }

//    //Handler

//    abstract class ScoreUpdater
//    {
//        protected ScoreUpdater successor;

//        public void SetSuccessor(ScoreUpdater successor)
//        {
//            this.successor = successor;
//        }

//        public abstract void IncrementScore(Enemy enemy);

//    }

//    //Enemy 1

//    class EasyA : ScoreUpdater
//    {
//        public override void IncrementScore(Enemy enemy)
//        {
//            if (enemy.Type == "EasyA")
//            {
//                Console.WriteLine("Incremented by 250");
//            }
//            else if (successor != null)
//            {
//                successor.IncrementScore(enemy);
//            }
//        }
//    }

//    //Enemy 2

//    class EasyB : ScoreUpdater
//    {
//        public override void IncrementScore(Enemy enemy)
//        {
//            if (enemy.Type == "EasyB")
//            {
//                Console.WriteLine("Increment by 500");
//            }
//            else if (successor != null)
//            {
//                successor.IncrementScore(enemy);
//            }
//        }
//    }


//    //Enemy 3

//    class HardA : ScoreUpdater
//    {
//        public override void IncrementScore(Enemy enemy)
//        {
//            if (enemy.Type == "HardA")
//            {
//                Console.WriteLine("Increment by 750");
//            }
//            else if (successor != null)
//            {
//                successor.IncrementScore(enemy);
//            }
//        }
//    }


//    //Enemy 4
//    class HardB : ScoreUpdater
//    {
//        public override void IncrementScore(Enemy enemy)
//        {
//            if (enemy.Type == "HardB")
//            {
//                Console.WriteLine("Increment by 1000");
//            }
//            else
//            {
//                Console.WriteLine("Cant handle");
//            }
//        }
//    }


//    //Enemy
//    public class Enemy
//    {
//        private string _type;

//        public Enemy(string type)
//        {
//            this._type = type;
//        }

//        //Getter and Setter

//        public string Type
//        {
//            get { return _type; }
//            set { _type = value; }
//        }
//    }
//}
