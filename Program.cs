namespace SayisalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int aa;
            int ab;
            int ac;
            int ad;
            int ae;
            int ar;
            int at;

            aa = rastgele.Next(0, 100);
            ab = rastgele.Next(0, 100);
            ac = rastgele.Next(0, 100);
            ad = rastgele.Next(0, 100);
            ae = rastgele.Next(0, 100);
            ar = rastgele.Next(0, 100);
            at = rastgele.Next(0, 100);

            Console.Write(aa + " " + ab + " " + " " + ac + " " + ad + "  " + ae + " " + ar + " " + at);
            Console.Read();
        }
    }
}