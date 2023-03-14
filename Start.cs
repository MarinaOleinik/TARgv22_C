using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv22_C
{
    public class Start
    {

        public static void Main(string[] args)
        {
            Dictionary<int,string> riigid = new Dictionary<int,string>(5);
            riigid.Add(1, "Eestimaa");
            riigid.Add(2, "Italia");
            riigid.Add(3, "Türgi");
            riigid.Add(4, "Hiina");
            riigid.Add(5, "Prantsusmaa");

            foreach (KeyValuePair<int,string> item in riigid)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Loom loom1= new Loom();
            loom1.Nimi = "Sharik";
            Console.Write(loom1.Nimi+" laulab: ");
            loom1.Loomi_häll();

            Loom loom2 = new Loom("Ruby");
            loom1.Nimi = "Almaz";

            Console.Write(loom1.Nimi + " laulab: ");
            loom1.Loomi_häll();
            Console.Write(loom2.Nimi + " laulab: ");
            loom2.Loomi_häll();

            Dictionary<int, Loom> loomad = new Dictionary<int, Loom>(4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Looma nimi: ");
                loomad.Add(i + 1, new Loom() { Nimi = Console.ReadLine() });
            }
            foreach (Loom item in loomad.Values)
            {
                Console.WriteLine(item.Nimi);
            }


            List<Loom> looms= new List<Loom>();
            looms.Add(loom1);
            looms.Add(loom2);
            looms.Add(new Loom() { Nimi = "Leo" });
            foreach (Loom item in looms)
            {
                Console.WriteLine(item.Nimi);
            }




            //Console.Write("Please enter a number to divide 100: ");

            //try
            //{
            //    int num = int.Parse(Console.ReadLine());

            //    int result = 100 / num;

            //    Console.WriteLine("100 / {0} = {1}", num, result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.Write("Cannot divide by zero. Please try again.");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.Write("Invalid operation. Please try again.");
            //}
            //catch (FormatException ex)
            //{
            //    Console.Write("Not a valid format. Please try again.");
            //}
            //catch (Exception ex)
            //{
            //    Console.Write("Error occurred! Please try again.");
            //}
            //Console.WriteLine("Sisesta arv1:");
            //double arv1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Tehe:");
            //string tehe = Console.ReadLine();
            //Console.WriteLine("Sisesta arv2:");
            //double arv2 = Convert.ToDouble(Console.ReadLine());
            //double vastus = Alamprogrammid.Kalkulaator(arv1,tehe,arv2);
            //Console.WriteLine(vastus);

            //double vastus1 = Alamprogrammid.Eval(4.ToString() + '+'.ToString() + 5.ToString());
            //Console.WriteLine(vastus1);

            //Console.WriteLine("Sisesta arv1:");
            //strting arv1=Console.ReadLine();
            //Console.WriteLine("Tehe:");
            //tehe = Console.ReadLine();
            //Console.WriteLine("Sisesta arv2:");
            //arv2 = Console.ReadLine();

            //vastus1 = Alamprogrammid.Eval(arv1+tehe+arv2);
            //Console.WriteLine("{0}{1}{2}={3}",arv1,tehe,arv2,vastus1);
        }
    }
}
