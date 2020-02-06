using System;

namespace AlgoFürAzubi4
{

    public class Program
    {

        static void Main(string[] args)
        {
            List<int> one = new List<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            one.Add(4);
            one.Add(5);
            one.Add(6);
            one.Add(7);
            one.Add(8);


            List<long> two = new List<long>();
            two.Add(11);
            two.Add(22);
            two.Add(33);
            two.Add(44);
            two.Add(55);
            two.Add(66);
            two.Add(77);
            two.Add(88);





            //  one.Insert(100, 15);
            // Console.WriteLine (two.IndexOf(55,0));

            // two.clear();
            // two.Display();


            // one.AddRange(two);

            one.Remove(2);
             one.Display();
            

        }
    }
}
