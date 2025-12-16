// 実行時間 10ms
using static System.Console;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        n = ( n & 1 ) != 0 ? n - 1 : n - 2;
        WriteLine( n / 2 );
        return;
    }
}
