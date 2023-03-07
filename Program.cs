// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nimi = Console.ReadLine();
if (nimi.ToUpper()=="JUKU")
{
    Console.WriteLine("Lahme kinno");
    int vanus = Convert.ToInt32(Console.ReadLine());
    if (vanus<0 || vanus>120) //&&-and ||-or
    {
        Console.WriteLine("Vanus ei saa {0} olla", vanus);
    }
    //kitjuta siia kood ise
}
else
{
    Console.WriteLine("Mind kodus pole");
}
Console.Clear();
Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Random rnd = new Random();
int hinne = rnd.Next(1, 5);
Console.WriteLine("Täna sai hinne {0}", hinne);
switch (hinne)
{
    case 1: Console.WriteLine("Õpi veel!");break;
    case 2: Console.WriteLine("Õpi natuke veel!"); break;
    case 3: Console.WriteLine("Rahuldav!"); break;
    case 4: Console.WriteLine("Hea tulemus!"); break;
    case 5: Console.WriteLine("Väga hea!"); break;
    default:
        Console.WriteLine("Viga!");
        break;
}

//Console.WriteLine("Tere, " + nimi);
//Console.WriteLine("Arv 1: ");
//int arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Arv 2: ");
//int arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tehe: ");
//char tehe = Convert.ToChar(Console.ReadLine()[0]);
//double vastus=0;
//if (tehe=='+')
//{
//    vastus = arv1 + arv2;
//}
//else if (tehe == '-')
//{
//    vastus = arv1 - arv2;
//}
//else if (tehe=='/')
//{
//    vastus = arv1 / arv2;
//}
//else
//{
//    Console.WriteLine("{0} - tundmatu tehe",tehe);
//}
//Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, vastus);