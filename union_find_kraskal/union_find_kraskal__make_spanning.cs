// 実行時間 30ms
using System;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class UnionFind
    {
        int R = 0;
        int W = 0;
        int[] A;
        ValueTuple<int, int>[] Em;
        ValueTuple<int, int, int>[] Eq;

        internal UnionFind( int[] n )
        {
            R = n[1];
            A = Repeat( -1, n[0] ).ToArray();
            Em = new (int, int)[n[1]];
            Eq = new (int, int, int)[n[2]];
        }

        internal void Edge( int[] n )
        {
            foreach( int i in Range( 0, n[1] ) ) {
                int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

                Em[i] = (a[0], a[1]);
            }
            foreach( int i in Range( 0, n[2] ) ) {
                int[] c = ReadLine().Split().Select( int.Parse ).ToArray();

                Eq[i] = (c[2], --c[0], --c[1]);
            }
            Eq = Eq.OrderByDescending( x => x.Item1 ).ToArray();
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

        internal void Print( int n )
        {
            WriteLine( n == R ? W : -1 );
            return;
        }

        internal void Union( int i )
        {
            var t = Em[i];
            int ra = ImprovedFind( t.Item1 );
            int rb = ImprovedFind( t.Item2 );

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

        internal void Union2( int n, int i )
        {
            if( n <= R ) {
                return;
            }

            var t = Eq[i];
            int rc = ImprovedFind( t.Item2 );
            int rd = ImprovedFind( t.Item3 );

            if( rc != rd ) {
                R++;
                W += t.Item1;
                if( -A[rc] < -A[rd] ) {
                    A[rc] = rd;
                } else if( -A[rd] < -A[rc] ) {
                    A[rd] = rc;
                } else {
                    A[rc]--;
                    A[rd] = rc;
                }
            }
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        UnionFind u = new UnionFind( n );

        u.Edge( n );
        foreach( int i in Range( 0, n[1] ) ) {
            u.Union( i );
        }
        foreach( int i in Range( 0, n[2] ) ) {
            u.Union2( n[0] - 1, i );
        }
        u.Print( n[0] - 1 );
        return;
    }
}
