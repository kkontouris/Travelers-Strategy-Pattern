namespace TravelApp
{
        public abstract class Traveller
        {
            public ITravel travelWith;

            public void SetTravelWith(ITravel tw)
            {
                this.travelWith = tw;
            }

            public abstract void Display();

            public void IamTravellingWith()
            {
                travelWith.Travel();
            }        
        }

}

