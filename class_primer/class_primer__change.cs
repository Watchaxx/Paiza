using System.Linq;
using static System.Console;

internal class Program
{
    class Person
    {
        int Old;
        string Birth;
        string Name;
        string State;

        internal Person( string n, int o, string b, string s )
        {
            Name = n;
            Old = o;
            Birth = b;
            State = s;
        }

        internal void ChangeName( string n )
        {
            Name = n;
            return;
        }

        internal void Print()
        {
            WriteLine( $"{Name} {Old} {Birth} {State}" );
            return;
        }
    }

    static void Main()
    {
        int[] nk = ReadLine().Split().Select( int.Parse ).ToArray();
        Person[] a = new Person[nk[0]];

        foreach( int i in Enumerable.Range( 0, nk[0] ) ) {
            string[] s = ReadLine().Split();

            a[i] = new Person( s[0], int.Parse( s[1] ), s[2], s[3] );
        }
        foreach( int i in Enumerable.Range( 0, nk[1] ) ) {
            string[] s = ReadLine().Split();

            a[int.Parse( s[0] ) - 1].ChangeName( s[1] );
        }
        foreach( Person p in a ) {
            p.Print();
        }
        return;
    }
}
