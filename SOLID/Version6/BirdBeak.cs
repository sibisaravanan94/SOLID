namespace SOLID.Version6
{
    public abstract class BirdBeak
    {
        public string name { get; set; }
        public string  material { get; set; }
        public Strength strength { get; set; }
    }

    public enum Strength
    {
        strong,
        medium,
        weak
    }
}