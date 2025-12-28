// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int l = ReadLine().Length;
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
        WriteLine( ( l & 1 ) == 0 ? Prt( p.Concat( p.Reverse() ) )
            : Prt( p.Concat( p.Take( p.Length - 1 ).Reverse() ) ) );
        return;
    }

    static string Prt( System.Collections.Generic.IEnumerable<int> a )
    {
        return string.Join( System.Environment.NewLine, a );
    }
}
