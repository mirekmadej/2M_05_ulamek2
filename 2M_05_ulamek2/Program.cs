namespace _2M_05_ulamek2
{
    class Ulamek
    {
        private int licznik = 0;
        private int mianownik = 0;

        public Ulamek(int licznik = 0,  int mianownik = 1)
        {
            this.licznik = licznik;
            if(mianownik != 0) 
                this.mianownik = mianownik;
        }
        public override string ToString()
        {
            return $"{licznik}/{mianownik}";
        }
        public static Ulamek operator -(Ulamek u)
        {
            return new Ulamek(-u.licznik, u.mianownik);
        }
        public static Ulamek operator +(Ulamek u)
        {
            return new Ulamek(u.licznik, u.mianownik);
        }
        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            int l = u1.licznik * u2.mianownik +u2.licznik*u1.mianownik;
            int m = u1.mianownik * u2.mianownik;
            return new Ulamek(l, m);
        }
        public static Ulamek operator +(int x, Ulamek u)
        {
            int l = x*u.mianownik + u.licznik;
            int m = u.mianownik;
            return new Ulamek(l, m);
        }
        //public static Ulamek operator !
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek u1 = new Ulamek(1,4);
            Ulamek u2 = new Ulamek(1,3);
           // u1.wypiszUlamek();
            Console.WriteLine(u1);
            Console.WriteLine(u2);
            Console.WriteLine(u1+u2);
            Console.WriteLine(5+u2);

            int x = 10;

            Console.WriteLine(1>0 ? "TAK " : "NIE");
        }
    }
}