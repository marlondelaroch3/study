using Technology.Models;

namespace Technology.Models
{
    public class AvailabilityCity
    {
        public Country country;
        public Cities city;
    }

    public enum Country
    {
        Colombia,
        Venezuela,
        Argentina,
        UnitedStates
    }
    public enum Cities
    {
        Bogota,
        Caracas,
        BuenosAires,
        NewYork,
        LosAngeles,
        Miami
    }
}