using Technology.Models;

namespace Technology.Models
{
    public class Microphone : Headphone
    {
        public override void GetAvailability()
        {
            foreach (var city in AvailabilityCities)
            {
                Console.WriteLine($"An Availability City for your microphone is {city.city} in {city.country}");
            }
        }
    }
}