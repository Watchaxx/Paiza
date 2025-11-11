using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in c ) {
            n[1] += i;
            if( i < 0 && n[1] <= n[2] ) {
                n[1] += n[3];
            }
        }
        WriteLine( n[1] );
        return;
    }
}
