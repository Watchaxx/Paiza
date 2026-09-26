// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] a = new int[7];

        foreach( int i in Range( 0, int.Parse( ReadLine() ) ) ) {
            a[i % 7] += int.Parse( ReadLine() );
        }
        WriteLine( string.Join( System.Environment.NewLine, a ) );
        return;
    }
}
