// 実行時間 90ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        var l = new List<int[]>();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        Permutation( l, Range( 1, int.Parse( ReadLine() ) ).ToList(), 0 );
        foreach( int[] i in l ) {
            WriteLine( string.Join( " ", i ) );
        }
        Out.Flush();
        return;
    }

    static void Permutation( List<int[]> p, List<int> t, int s )
    {
        for( int i = s; i < t.Count; i++ ) {
            Swap( t, i, s );
            Permutation( p, t, s + 1 );
            Swap( t, i, s );
        }
        if( s == t.Count - 1 ) {
            p.Add( t.ToArray() );
        }
        return;
    }

    static void Swap( List<int> l, int i, int j )
    {
        // (l[i], l[j]) = (l[j], l[i]);
        int t = l[i];
        l[i] = l[j];
        l[j] = t;
        return;
    }
}
