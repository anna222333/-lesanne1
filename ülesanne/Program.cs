
internal class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Choose figure- Ruudu 1, Ristküliku 2, ringi 3 . ");
        int Figure = Convert.ToInt32(Console.ReadLine());




        switch (Figure)
        {
            case 1:
                Console.WriteLine(" Ruudu ");
                Console.WriteLine("Sisesta number ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ruudu pindala on " + number * number);


                break;

            case 2:
                Console.WriteLine("Ristküliku");
                Console.WriteLine("Sisesta esimene number ");
                int secondnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sesesta teise number ");
                int firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ristküliku pindala on  " + secondnumber * firstnumber);


                break;

            case 3:
                Console.WriteLine("ringi");
                Console.WriteLine("Sisesta number ");
                double pi = Math.PI;
                int thirdnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ringi pindala on  " + (thirdnumber * thirdnumber) * pi);
                break;

            default:
                Console.WriteLine("Error");
                break;
        }


    }
}