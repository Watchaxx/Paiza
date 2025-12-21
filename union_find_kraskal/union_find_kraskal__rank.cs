// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class UnionFind
    {
        int[] A;
        int[] R;

        internal UnionFind( int n )
        {
            A = Range( 0, n ).ToArray();
            R = Repeat( 1, n ).ToArray();
        }

        internal int ImprovedFind( int x )
        {
            if( x == A[x] ) {
                return x;
            } else {
                A[x] = ImprovedFind( A[x] );
                return A[x];
            }
        }

        internal void Print()
        {
            WriteLine( string.Join( System.Environment.NewLine, A ) );
            WriteLine( string.Join( System.Environment.NewLine, R ) );
            return;
        }

        internal void Rank( int a, int b )
        {
            int ra = ImprovedFind( a );
            int rb = ImprovedFind( b );

            if( ra != rb ) {
                if( R[ra] < R[rb] ) {
                    A[ra] = rb;
                } else if( R[rb] < R[ra] ) {
                    A[rb] = ra;
                } else {
                    A[rb] = ra;
                    R[ra]++;
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
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            u.Rank( a[0], a[1] );
        }
        u.Print();
        return;
    }
}
