// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class UnionFind
    {
        int[] A;

        internal UnionFind( int[] a )
        {
            A = a;
        }

        internal int Find( int x )
        {
            return A[x] == x ? x : Find( A[x] );
        }
    }

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        UnionFind u = new UnionFind( ReadLine().Split().Select( int.Parse ).ToArray() );
        WriteLine( u.Find( int.Parse( ReadLine() ) ) );
        return;
    }
}
