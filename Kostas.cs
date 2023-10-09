namespace TravelApp
{
        public class Kostas : Traveller
        {
            public Kostas()
            {
                travelWith= new TravelWithCar();
            }
            public override void Display()
            {
                Console.WriteLine("I am Kostas"); ;
            }
        }
}

