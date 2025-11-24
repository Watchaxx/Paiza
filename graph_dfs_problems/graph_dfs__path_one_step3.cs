// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = new List<int>[n[0] + 1];
        var l = new List<int>() { n[1] };

        foreach( int i in Range( 1, n[0] ) ) {
            var t = Range( 1, n[0] ).ToList();

            t.Remove( i );
            a[i] = t;
        }
        foreach( int _ in Range( 0, n[2] ) ) {
            int[] t = a[n[1]].Except( l ).ToArray();
            var r = new System.Random();

            l.Add( t[r.Next( t.Length )] );
        }
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
