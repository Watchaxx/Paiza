using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] n = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0] + 2];

        a[0] = n[1];
        a[1] = n[2];
        foreach( int i in Enumerable.Range( 2, n[0] ) ) {
            a[i] = int.Parse( Console.ReadLine() );
        }
        Array.Sort( a );
        Console.WriteLine( Array.IndexOf( a, n[2] ) + 1 );
        return;
    }
}
