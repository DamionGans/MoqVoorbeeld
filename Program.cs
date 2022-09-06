namespace Programa
{
    public class Programma
    {
        public int Add(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
        public string Begroeting(Begroetingsgenerator generator, string naam)
        {
            return generator.Genereer() + " " + naam;
        }
        public static void Main(string[] args)
        {

        }
    }

    public abstract class Begroetingsgenerator
    {
        public readonly string Begroeting;
        public Begroetingsgenerator(string begroeting)
        {
            Begroeting = begroeting;
        }
        public abstract string Genereer();
    }
    public class VriendelijkeBegroeting : Begroetingsgenerator
    {
        public VriendelijkeBegroeting(string begroeting) : base(begroeting)
        {
        }

        public override string Genereer()
        {
            return ":)" + Begroeting;
        }
    }
}