// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int n = int.Parse( ReadLine() );

        while( b < n ) {
            a++;
            b *= 2;
        }
        WriteLine( a );
        return;
    }
}
