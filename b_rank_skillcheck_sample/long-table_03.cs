// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        ReadLine();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        WriteLine( string.Join( " ", Range( a[1], a[0] ) ) );
        return;
    }
}
