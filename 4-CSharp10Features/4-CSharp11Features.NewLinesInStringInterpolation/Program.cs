
var wind = (WindDirection)new Random().Next(0, 4);

var message = $"Wind is blowing from the {wind switch
{
    WindDirection.N => "north",
    WindDirection.E => "east",
    WindDirection.S => "south",
    WindDirection.W => "west"
}}";

Console.WriteLine(message);

public enum WindDirection { N, E, S, W }