using System.Linq;
using static System.Console;

internal class Program
{
    abstract class Car
    {
        internal int Cons { get; set; }
        internal int Fuel { get; set; }
        internal int Len { get; set; } = 0;

        protected Car( int f, int c )
        {
            Cons = c;
            Fuel = f;
        }

        internal abstract void Fly();
        internal abstract void Run();
        internal abstract void Telepo();
    }

    class SC : Car
    {
        internal SC( int f, int c ) : base( f, c ) { }

        internal override void Run()
        {
            if( 0 < Fuel ) {
                Fuel--;
                Len += Cons;
            }
            return;
        }

        internal override void Fly() { }
        internal override void Telepo() { }
    }

    class SSC : SC
    {
        internal SSC( int f, int c ) : base( f, c ) { }

        internal override void Fly()
        {
            if( 5 <= Fuel ) {
                Fuel -= 5;
                Len += Cons * Cons;
            } else {
                Run();
            }
            return;
        }
    }

    class UC : SSC
    {
        internal UC( int f, int c ) : base( f, c ) { }

        internal override void Fly()
        {
            if( 5 <= Fuel ) {
                Fuel -= 5;
                Len += 2 * Cons * Cons;
            } else {
                Run();
            }
            return;
        }

        internal override void Telepo()
        {
            if( Cons * Cons <= Fuel ) {
                Fuel -= Cons * Cons;
                Len += (int)System.Math.Pow( Cons, 4d );
            } else {
                Fly();
            }
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        Car[] a = new Car[n[0]];

        foreach( int i in Enumerable.Range( 0, n[0] ) ) {
            string[] t = ReadLine().Split();

            switch( t[0] ) {
            case "supercar":
                a[i] = new SC( int.Parse( t[1] ), int.Parse( t[2] ) );
                break;
            case "supersupercar":
                a[i] = new SSC( int.Parse( t[1] ), int.Parse( t[2] ) );
                break;
            case "supersupersupercar":
                a[i] = new UC( int.Parse( t[1] ), int.Parse( t[2] ) );
                break;
            }
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            string[] t = ReadLine().Split();

            switch( t[1] ) {
            case "run":
                a[int.Parse( t[0] ) - 1].Run();
                break;
            case "fly":
                a[int.Parse( t[0] ) - 1].Fly();
                break;
            case "teleport":
                a[int.Parse( t[0] ) - 1].Telepo();
                break;
            }
        }
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( Car c in a ) {
            WriteLine( c.Len );
        }
        Out.Flush();
        return;
    }
}
