// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    class UnionFind
    {
        int[] A;
        Lst[] V;

        internal UnionFind( int n, string v )
        {
            A = Repeat( -1, n ).ToArray();
            V = new Lst[n];
            foreach( var p in v.Split().Select( ( a, i ) => new { a, i } ) ) {
                V[p.i] = new Lst() { int.Parse( p.a ) };
            }
        }

        internal int ImprovedFind( int x )
        {
            if( A[x] < 0 ) {
                return x;
            } else {
                A[x] = ImprovedFind( A[x] );
                return A[x];
            }
        }

        internal void Print()
        {
            int o = 0;

            foreach( Lst l in V ) {
                o = System.Math.Max( o, l.Sum() );
            }
            WriteLine( o );
            return;
        }

        internal void Union( int a, int b )
        {
            int ra = ImprovedFind( a );
            int rb = ImprovedFind( b );

            if( ra == rb || V[ra].Average() <= V[rb].Average() ) {
                return;
            }
            if( -A[ra] < -A[rb] ) {
                A[ra] = rb;
                V[rb].AddRange( V[ra] );
            } else if( -A[rb] < -A[ra] ) {
                A[rb] = ra;
                V[ra].AddRange( V[rb] );
            } else {
                A[ra]--;
                A[rb] = ra;
                V[ra].AddRange( V[rb] );
            }
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        UnionFind u = new UnionFind( n[0], ReadLine() );

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            u.Union( a[0], a[1] );
        }
        u.Print();
        return;
    }
}
