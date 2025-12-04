// 実行時間 180ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] g = new int[n[0] + n[1] + 1];
        string[] d = new string[n[0]];
        string[] f = new string[n[0]];
        string[] s = new string[n[2]];
        string[] x = new string[n[1]];
        string[] y = new string[n[1]];
        var i2f = new Dictionary<int, string>();
        var f2i = new Dictionary<string, int>();

        foreach( int i in Range( 0, n[0] ) ) {
            string[] t = ReadLine().Split();

            f[i] = t[0];
            d[i] = t[1];
        }
        foreach( int i in Range( 0, n[1] ) ) {
            string[] t = ReadLine().Split();

            x[i] = t[0];
            y[i] = t[1];
        }
        foreach( int i in Range( 0, n[2] ) ) {
            s[i] = ReadLine();
        }
        f2i["root"] = 0;
        foreach( int i in Range( 0, n[0] ) ) {
            f2i[f[i]] = f2i.Count;
            i2f[f2i[f[i]]] = f[i];
            if( f2i.ContainsKey( d[i] ) != true ) {
                f2i[d[i]] = f2i.Count;
                i2f[f2i[d[i]]] = d[i];
            }
        }
        foreach( int i in Range( 0, n[1] ) ) {
            if( f2i.ContainsKey( x[i] ) != true ) {
                f2i[x[i]] = f2i.Count;
                i2f[f2i[x[i]]] = x[i];
            }
            if( f2i.ContainsKey( y[i] ) != true ) {
                f2i[y[i]] = f2i.Count;
                i2f[f2i[y[i]]] = y[i];
            }
        }
        foreach( int i in Range( 0, n[0] ) ) {
            g[f2i[f[i]]] = f2i[d[i]];
        }
        foreach( int i in Range( 0, n[1] ) ) {
            g[f2i[y[i]]] = f2i[x[i]];
        }
        foreach( string i in s ) {
            int c = f2i[i];
            var l = new List<string>();

            while( c != 0 ) {
                l.Add( i2f[c] );
                c = g[c];
            }
            l.Reverse();
            WriteLine( $"root/{string.Join( "/", l )}" );
        }
        return;
    }
}
