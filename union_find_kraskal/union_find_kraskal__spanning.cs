// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class UnionFind
    {
        int[] A;

        internal UnionFind( int n )
        {
            A = Repeat( -1, n ).ToArray();
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
            WriteLine( A.Count( x => x < 0 ) == 1 ? "Yes" : "No" );
            return;
        }

        internal void Union( int a, int b )
        {
            int ra = ImprovedFind( a );
            int rb = ImprovedFind( b );

            if( ra != rb ) {
                if( -A[ra] < -A[rb] ) {
                    A[ra] = rb;
                } else if( -A[rb] < -A[ra] ) {
                    A[rb] = ra;
                } else {
                    A[ra]--;
                    A[rb] = ra;
                }
            }
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        UnionFind u = new UnionFind( n[0] );

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            u.Union( a[0], a[1] );
        }
        u.Print();
        return;
    }
}
