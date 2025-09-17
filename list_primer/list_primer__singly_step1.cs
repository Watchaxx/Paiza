// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        const int cnt = 1024;
        int n = int.Parse( ReadLine() );
        int back = 0;
        int empty = 1;
        sbyte[] value = new sbyte[cnt];
        sbyte[] next = new sbyte[cnt];

        value[0] = -1;
        value[cnt - 1] = -1;
        next[0] = sbyte.MaxValue;
        next[cnt - 1] = -1;
        for( int _ = 0; _ < n; _++ ) {
            WriteLine( ReadLine() );
        }
        return;
    }
}
