namespace Technology.Interfaces
{
    public interface ITechnology
    {
        int Id { get; set; }
        string Size { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
    }
}