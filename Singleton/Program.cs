using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game=new Game("KFC tournament","Football", 2018,"My team");
            Sports sports=Sports.init;
            sports.getGameStats(game);

        }
    }
}
