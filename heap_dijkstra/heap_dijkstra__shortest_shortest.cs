// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.ValueTuple<int, int>;

class Program
{
    static List<Tpl> Heap = new List<Tpl>();

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var d = new Dictionary<int, List<Tpl>>( n[0] );

        foreach( int i in Range( 1, n[0] ) ) {
            d.Add( i, new List<Tpl>() );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            d[a[0]].Add( (a[1], a[2]) );
        }
        foreach( Tpl p in d[n[2]] ) {
            Push( p.Item1, p.Item2 );
        }
        if( 0 < Heap.Count ) {
            Tpl v = Heap[0];

            WriteLine( v.Item1 );
            Pop();
            foreach( Tpl p in d[v.Item1] ) {
                Push( p.Item1, p.Item2 + v.Item2 );
            }
            WriteLine( 0 < Heap.Count ? $"{Heap[0].Item1}" : "inf" );
        } else {
            WriteLine( $"inf{System.Environment.NewLine}inf" );
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

    static void Push( int a, int b )
    {
        int c = Heap.Count;

        Heap.Add( (a, b) );
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
        Tpl t = Heap[a];
        Heap[a] = Heap[b];
        Heap[b] = t;
    }
}
