using System ;

namespace csharp_enum

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday) ;
            Console.WriteLine((int)Days.Saturday) ;

            int weather= 32;
            if (weather <= (int)Weather.RoomTemp)
                {
                    Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekle") ;
                }
            else if (weather >= (int)Weather.Hot)
                {
                    Console.WriteLine("Disariya cikmak icin cok sicak bir gun") ;
                }
            else if (weather >= (int)Weather.RoomTemp && weather <= (int)Weather.Hot)
                {
                    Console.WriteLine("Let's go to the outside") ;
                }

        } 
    }
    enum Days
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Weather
    {
        Cold = 5 ,
        Hot = 35,
        RoomTemp = 25
    }
}