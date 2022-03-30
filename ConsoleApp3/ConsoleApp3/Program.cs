using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Tiger a = new Tiger();

            //Swan s = new Swan();


            //Animal anim = new Shark();
            //Fish fish  = new Shark();
            //Shark shark = new Shark();

            //Console.WriteLine(s.Test());

            //s.Move();
            //shark.Move();
            //HammerHead hh = new HammerHead();

            //hh.MakeSount();

            //Person person = new Person();
            //person.Name = "Rasim";
            //person.Surname = "Aliyev";
            //person.Age = 45;

            //Person person2 = new Person();
            //person2.Name = "Mamed";
            //person2.Surname = "Balayev";
            //person2.Age = 21;


            //Console.WriteLine(person);
            #endregion

            //Person p = new Person();

            //ILivable p2 = new Person();

            Person p1 = new Person();
            p1.Age = 41;
            p1.Name = "Isaba";
            p1.Surname = "Qemberov";

            Person p2 = new Person();
            p2.Age = 9;
            p2.Name = "Qudret";
            p2.Surname = "Balayev";

            Person p3 = new Person();
            p3.Age = 21;
            p3.Name = "Qabil";
            p3.Surname = "Xudiyev";

            //Person[] people = { p1, p2, p3 };

            //Array.Sort(people);

            //int a = 5;

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(p3.CompareTo(p1));

        }

        //public class Entity
        //{

        //}

        //public class Person : Entity, ILivable , ISleepable
        //{
        //    public string Name { get; set; }
        //    public void Move()
        //    {
        //        Console.WriteLine("Gezirem");
        //    }
        //}

        //public class Animal : Entity, ILivable , ISleepable
        //{
        //}

        //public interface ILivable
        //{
        //    public void Move(){ }
        //    public void Eat(){ }
        //    public void Breath(){ }
        //    public void Drink(){ }
        //}

        //public interface ISleepable
        //{
        //    public void Sleep() { }
        //}

        ////public class Car : Imoveable
        ////{
        ////    public void Move()
        ////    {
        ////        Console.WriteLine("Suzulurem");
        ////    }
        ////}

        //public class BankAccount : IBalancable , IWithDrawable
        //{
        //    public double Balance { get; set; }
        //}
        //public class BankCard : IBalancable , IWithDrawable
        //{
        //    public double Balance { get; set; }
        //}

        //public interface IBalancable
        //{
        //    public double Balance { get; set; }
        //}

        //public interface IWithDrawable
        //{
        //    public void Withdraw() { }
        //}


        #region
        //static int Sum(int n1, int n2)
        //{
        //    return n1 + n2;
        //}

        //static int Sum(int n1, int n2, int n3)
        //{
        //    return n1 + n2 + n3;
        //}
        #endregion
    }
}
