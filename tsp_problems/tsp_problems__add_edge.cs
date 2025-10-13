// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    class UnionFind
    {
        Lst Parent;

        public UnionFind( int i )
        {
            Parent = new Lst( Range( 0, i ) );
        }

        public bool Equal( int a, int b )
        {
            return GetParent( a ) == GetParent( b );
        }

        public int GetParent( int a )
        {
            if( a != Parent[a] ) {
                Parent[a] = GetParent( Parent[a] );
            }
            return Parent[a];
        }

        public void Unite( int a, int b )
        {
            Parent[GetParent( b )] = GetParent( a );
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n[0]];
        var u = new UnionFind( n[0] );

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            d[a[0]]++;
            d[a[1]]++;
            u.Unite( a[0], a[1] );
        }

        int[] e = ReadLine().Split().Select( int.Parse ).ToArray();

        d[e[0]]++;
        d[e[1]]++;
        WriteLine( d[e[0]] <= 2 && d[e[1]] <= 2 && u.Equal( e[0], e[1] ) != true ? "Yes" : "No" );
        return;
    }
}
