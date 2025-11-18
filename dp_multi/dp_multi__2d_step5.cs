// 実行時間 1520ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] l = new int[21];
        string s = ReadLine();
        bool[,] d = new bool[21, s.Length + 1];

        l[1] = 1;
        l[2] = 1;
        l[3] = 1;
        foreach( int i in Range( 4, 17 ) ) {
            l[i] = l[i - 1] + l[i - 2] + l[i - 3];
        }
        foreach( int i in Range( 0, s.Length ) ) {
            if( s[i] == '1' ) {
                d[1, i] = true;
            } else if( s[i] == '2' ) {
                d[2, i] = true;
            } else if( s[i] == '3' ) {
                d[3, i] = true;
            }
        }
        foreach( int i in Range( 4, 17 ) ) {
            var pairs = new[] {
                (i - 1, l[i - 1]), (i - 2, l[i - 2]), (i - 3, l[i - 3]) };

            for( int j = 0; j <= s.Length - l[i]; j++ ) {
                foreach( var p in Perm( pairs ).Where( x => d[x[0].Item1, j]
                    && d[x[1].Item1, j + x[0].Item2]
                    && d[x[2].Item1, j + x[0].Item2 + x[1].Item2] ) ) {
                    d[i, j] = true;
                }
            }
        }
        foreach( int i in Range( 1, 20 ) ) {
            for( int j = 0; j <= s.Length - l[i]; j++ ) {
                if( d[i, j] == true ) {
                    o = i;
                }
            }
        }
        WriteLine( o );
        return;
    }

    static List<(int, int)[]> Perm( (int, int)[] a )
    {
        int[][] pi = new int[][] {
            new[] { 0, 1, 2 }, new[] { 0, 2, 1 },
            new[] { 1, 0, 2 }, new[] { 1, 2, 0 },
            new[] { 2, 0, 1 }, new[] { 2, 1, 0 } };
        var l = new List<(int, int)[]>();

        foreach( int[] i in pi ) {
            l.Add( new[] { a[i[0]], a[i[1]], a[i[2]] } );
        }
        return l;
    }
}
