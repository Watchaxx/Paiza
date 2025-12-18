// 実行時間 30ms
using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

class Program
{
    static List<ValueTuple<int, int, int>> Heap;

    static void Main()
    {
        int[] n = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = Repeat( -1, n[0] ).ToArray();
        int[] p = Repeat( -1, n[0] ).ToArray();
        var d = new Dictionary<int, List<ValueTuple<int, int>>>( n[0] );

        c[n[2] - 1] = 0;
        p[n[2] - 1] = n[2];
        foreach( int i in Range( 1, n[0] ) ) {
            d.Add( i, new List<ValueTuple<int, int>>() );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = Console.ReadLine().Split().Select( int.Parse ).ToArray();

            d[a[0]].Add( (a[1], a[2]) );
        }

        var st = Dijkstra( n[2], n[3], d );
        var tg = Dijkstra( n[3], n[4], d );

        if( st.Item1 < 0 || tg.Item1 < 0 ) {
            Console.WriteLine( "inf" );
        } else {
            Console.WriteLine( st.Item1 + tg.Item1 );
            Console.WriteLine( string.Join( " ", st.Item2.Take( st.Item2.Count - 1 ).Concat( tg.Item2 ) ) );
        }
        return;
    }

    static ValueTuple<int, List<int>> Dijkstra( int s, int g, Dictionary<int, List<ValueTuple<int, int>>> d )
    {
        int[] c = Repeat( -1, d.Count ).ToArray();
        int[] p = Repeat( -1, d.Count ).ToArray();

        c[s - 1] = 0;
        p[s - 1] = s;
        Heap = new List<ValueTuple<int, int, int>>();
        foreach( var t in d[s] ) {
            Push( t.Item1, t.Item2, s );
        }
        while( 0 < Heap.Count ) {
            var v = Heap[0];

            if( c[v.Item1 - 1] != -1 ) {
                Pop();
                continue;
            }
            c[v.Item1 - 1] = v.Item2;
            p[v.Item1 - 1] = v.Item3;
            if( v.Item1 == g ) {
                break;
            }
            Pop();
            foreach( var t in d[v.Item1] ) {
                Push( t.Item1, t.Item2 + v.Item2, v.Item1 );
            }
        }
        if( c[g - 1] != -1 ) {
            int e = g;
            var r = new List<int>() { g };

            while( e != s ) {
                e = p[e - 1];
                r.Add( e );
            }
            r.Reverse();
            return (c[g - 1], r);
        }
        return (-1, null);
    }

    static bool IsSmall( int a, int b )
    {
        return Heap[a].Item2 < Heap[b].Item2 || ( Heap[a].Item2 == Heap[b].Item2 && Heap[a].Item1 < Heap[b].Item1 );
    }

    static void Pop()
    {
        int c = 0;

        Heap[0] = Heap[Heap.Count - 1];
        Heap.RemoveAt( Heap.Count - 1 );
        while( 2 * c + 1 < Heap.Count ) {
            int l = 2 * c + 1;
            int r = 2 * c + 2;

            if( r < Heap.Count ) {
                if( IsSmall( l, c ) && IsSmall( l, r ) ) {
                    Swap( l, c );
                    c = l;
                } else if( IsSmall( r, c ) ) {
                    Swap( r, c );
                    c = r;
                } else {
                    break;
                }
            } else if( IsSmall( l, c ) ) {
                Swap( l, c );
                c = l;
            } else {
                break;
            }
        }
        return;
    }

    static void Push( int a, int b, int r )
    {
        int c = Heap.Count;

        Heap.Add( (a, b, r) );
        while( 0 < c ) {
            int p = ( c - 1 ) / 2;

            if( IsSmall( c, p ) ) {
                Swap( c, p );
                c = p;
            } else {
                break;
            }
        }
        return;
    }

    static void Swap( int a, int b )
    {
        var t = Heap[a];
        Heap[a] = Heap[b];
        Heap[b] = t;
    }
}
