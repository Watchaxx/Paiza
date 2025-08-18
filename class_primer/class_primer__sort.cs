using System.Linq;
using static System.Console;

internal class Program
{
    class Person
    {
        public int Old;
        public string Birth;
        public string Name;
        public string State;

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
        foreach( Person p in a.OrderBy( x => x.Old ) ) {
            WriteLine( $"{p.Name} {p.Old} {p.Birth} {p.State}" );
        }
        return;
    }
}
