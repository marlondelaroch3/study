using Technology.Interfaces;

namespace Technology.Models
{
    public class Headphone : ITechnology
    {

        private string _Color;
        public int Id { get; set; }
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value.Trim();
            }
        }
        public string Size { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<AvailabilityCity> AvailabilityCities;
        public bool Warranty;
        public Headphone()
        {
            _Color = "";
            Color = "";
            Size = "";
            Brand = "";
            Model = "";
            AvailabilityCities = new List<AvailabilityCity>();
        }
        public virtual void GetAvailability()
        {
            foreach (var city in AvailabilityCities)
            {
                Console.WriteLine($"An Availability City is {city.city} in {city.country}");
            }
        }
    }
}