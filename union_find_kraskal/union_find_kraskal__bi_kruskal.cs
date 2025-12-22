// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class UnionFind
    {
        int R = 0;
        int W = 0;
        int[] A;
        System.ValueTuple<int, int, int, int>[] E;

        internal UnionFind( int n )
        {
            A = Repeat( -1, n ).ToArray();
            E = new (int, int, int, int)[n * ( n - 1 ) / 2];
        }

        internal void Edge( int n )
        {
            foreach( int i in Range( 0, n ) ) {
                int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

                E[i] = (a[2], a[3], --a[0], --a[1]);
            }
            E = E.OrderBy( x => x.Item1 ).ThenByDescending( x => x.Item2 ).ToArray();
            return;
        }

        int ImprovedFind( int x )
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
            WriteLine( W );
            return;
        }

        internal void Union( int n, int i )
        {
            if( n == R ) {
                return;
            }

            var t = E[i];
            int rs = ImprovedFind( t.Item3 );
            int rt = ImprovedFind( t.Item4 );

            if( rs != rt ) {
                R++;
                W += t.Item2;
                if( -A[rs] < -A[rt] ) {
                    A[rs] = rt;
                } else if( -A[rt] < -A[rs] ) {
                    A[rt] = rs;
                } else {
                    A[rs]--;
                    A[rt] = rs;
                }
            }
            return;
        }
    }

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        UnionFind u = new UnionFind( n );

        u.Edge( n * ( n - 1 ) / 2 );
        foreach( int i in Range( 0, n * ( n - 1 ) / 2 ) ) {
            u.Union( n - 1, i );
        }
        u.Print();
        return;
    }
}
