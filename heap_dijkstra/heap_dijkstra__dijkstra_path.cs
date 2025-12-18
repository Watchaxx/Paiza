// 実行時間 20ms
using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

class Program
{
    static List<ValueTuple<int, int, int>> Heap = new List<ValueTuple<int, int, int>>();

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
        foreach( var t in d[n[2]] ) {
            Push( t.Item1, t.Item2, n[2] );
        }
        while( 0 < Heap.Count ) {
            var v = Heap[0];

            if( c[v.Item1 - 1] != -1 ) {
                Pop();
                continue;
            }
            c[v.Item1 - 1] = v.Item2;
            p[v.Item1 - 1] = v.Item3;
            if( v.Item1 == n[3] ) {
                break;
            }
            Pop();
            foreach( var t in d[v.Item1] ) {
                Push( t.Item1, t.Item2 + v.Item2, v.Item1 );
            }
        }
        if( c[n[3] - 1] != -1 ) {
            int e = n[3];
            var l = new List<int>() { n[3] };

            while( e != n[2] ) {
                e = p[e - 1];
                l.Add( e );
            }
            l.Reverse();
            Console.WriteLine( c[n[3] - 1] );
            Console.WriteLine( string.Join( " ", l ) );
        } else {
            Console.WriteLine( "inf" );
        }
        return;
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
