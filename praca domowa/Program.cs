using System;



namespace paracadomowa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 50;
            double b = 30;

            Math math = new Math();

            double addResoult = math.Add(a, b);

            double substractResoult = math.Substract(a, b);

            Console.WriteLine(addResoult .ToString());
            Console.WriteLine(substractResoult . ToString());
            

        }


    }
}



