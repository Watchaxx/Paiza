// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class UnionFind
    {
        int[] A;

        internal UnionFind( int n )
        {
            A = Range( 0, n ).ToArray();
        }

        internal int Find( int x )
        {
            return A[x] == x ? x : Find( A[x] );
        }

        internal void Print()
        {
            WriteLine( string.Join( System.Environment.NewLine, A ) );
            return;
        }

        internal void Union( int a, int b )
        {
            int ra = Find( a );
            int rb = Find( b );

            if( ra != rb ) {
                A[rb] = ra;
            }
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        UnionFind u = new UnionFind( n[0] );

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            u.Union( a[0], a[1] );
        }
        u.Print();
        return;
    }
}
