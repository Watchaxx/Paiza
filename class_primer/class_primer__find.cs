using System.Linq;
using static System.Console;

internal class Program
{
    class Person
    {
        public int Old;
        string Birth;
        public string Name;
        string State;

        public Person( string n, int o, string b, string s )
        {
            Name = n;
            Old = o;
            Birth = b;
            State = s;
        }
    }

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        Person[] a = new Person[n];

        foreach( int i in Enumerable.Range( 0, n ) ) {
            string[] s = ReadLine().Split();

            a[i] = new Person( s[0], int.Parse( s[1] ), s[2], s[3] );
        }

        int k = int.Parse( ReadLine() );

        foreach( Person p in a.Where( x => x.Old == k ) ) {
            WriteLine( p.Name );
        }
        return;
    }
}
