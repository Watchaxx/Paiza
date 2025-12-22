// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<System.ValueTuple<int, int>>;

class Program
{
    class UnionFind
    {
        int W = 0;
        int[] A;
        System.ValueTuple<int, int, int>[] E;
        Lst T = new Lst();

        internal UnionFind( int[] n )
        {
            A = Repeat( -1, n[0] ).ToArray();
            E = new (int, int, int)[n[1]];
        }

        internal void Edge( int m )
        {
            foreach( int i in Range( 0, m ) ) {
                int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

                E[i] = (a[2], --a[0], --a[1]);
            }
            E = E.OrderBy( x => x.Item1 ).ToArray();
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
            WriteLine( string.Join( System.Environment.NewLine, T.Select( x => $"{x.Item1} {x.Item2}" ) ) );
            return;
        }

        internal void Union( int i )
        {
            var t = E[i];
            int ra = ImprovedFind( t.Item2 );
            int rb = ImprovedFind( t.Item3 );

            if( ra != rb ) {
                W += t.Item1;
                T.Add( (t.Item2 + 1, t.Item3 + 1) );
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
        UnionFind u = new UnionFind( n );

        u.Edge( n[1] );
        foreach( int i in Range( 0, n[1] ) ) {
            u.Union( i );
        }
        u.Print();
        return;
    }
}
