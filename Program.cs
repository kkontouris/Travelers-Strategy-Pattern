using System;

namespace TravelApp
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            Traveller travellerKostas = new Kostas();
            travellerKostas.Display();
            travellerKostas.IamTravellingWith();
            travellerKostas.SetTravelWith(new TravelWithShip());
            travellerKostas.Display();
            travellerKostas.IamTravellingWith();
            Traveller travellerMagda = new Magda();
            Console.WriteLine("..............................");
            travellerMagda.Display();
            travellerMagda.IamTravellingWith();

        }

    }
}

