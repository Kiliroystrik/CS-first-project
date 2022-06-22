namespace C__begginings
{
    public enum Color
    {
        green,
        red,
        blue,
        white
    }

    public abstract class Vehicule
    {
        public bool Repare { get; set; }
    }
    public class Car : Vehicule
    {
        public string? Brand { get; set; }
        public Color Color { get; set; }
        public DateTime DateEntretien { get; set; }
    }
    public class Bus : Vehicule
    {

    }
}