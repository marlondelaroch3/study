using Technology;
using Technology.Models;
var city1 = new AvailabilityCity();
var city2 = new AvailabilityCity();
var city3 = new AvailabilityCity();

var printInfo = new PrintInfo();
city1.country = Country.Colombia;
city1.city = Cities.Bogota;
city2.country = Country.Venezuela;
city2.city = Cities.Caracas;
city3.country = Country.Argentina;
city3.city = Cities.BuenosAires;

var myHeadphones1 = new Headphone();
var myHeadphones2 = new Headphone();


List<AvailabilityCity> availabilityCity = new List<AvailabilityCity>();
List<AvailabilityCity> availabilityCity2 = new List<AvailabilityCity>();

availabilityCity.Add(city2);
availabilityCity2.Add(city1);
availabilityCity2.Add(city3);

myHeadphones1.Id = 1;
myHeadphones1.Color = "Black";
myHeadphones1.Size = "Large";
myHeadphones1.Brand = "Sony";
myHeadphones1.Model = "WH-1000XM4";
myHeadphones1.AvailabilityCities = availabilityCity;
myHeadphones1.Warranty = true;

myHeadphones2.Id = 2;
myHeadphones2.Color = "White";
myHeadphones2.Size = "Small";
myHeadphones2.Brand = "Apple";
myHeadphones2.Model = "AirPods Pro";


myHeadphones2.AvailabilityCities = availabilityCity2;
myHeadphones2.Warranty = false;

myHeadphones1.GetAvailability();
Console.WriteLine("--------------------------------------------");
myHeadphones2.GetAvailability();
Console.WriteLine("--------------------------------------------");



var city4 = new AvailabilityCity();
city4.country = Country.UnitedStates;
city4.city = Cities.NewYork;

List<AvailabilityCity> microphoneAvailabilityCity = new List<AvailabilityCity>();
microphoneAvailabilityCity.Add(city4);

var myMicrophone1 = new Microphone();
myMicrophone1.Id = 1;
myMicrophone1.Color = "Black";
myMicrophone1.Size = "Small";
myMicrophone1.Brand = "Audio-Technica";
myMicrophone1.Model = "AT2020";
myMicrophone1.AvailabilityCities = microphoneAvailabilityCity;
myMicrophone1.Warranty = true;

myMicrophone1.GetAvailability();
Console.WriteLine("--------------------------------------------");
printInfo.Print(myMicrophone1);
Console.WriteLine("--------------------------------------------");
printInfo.Print(myHeadphones1);
Console.WriteLine("--------------------------------------------");
printInfo.Print(myHeadphones2);