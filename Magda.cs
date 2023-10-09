namespace TravelApp
{
        public class Magda : Traveller
        {
            public Magda()
            {
                travelWith = new TravelWithShip();
            }
            public override void Display()
            {
                Console.WriteLine("I am Magda"); ;
            }
        }
}

