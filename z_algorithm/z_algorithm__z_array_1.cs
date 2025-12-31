// 実行時間 10ms
using static System.Console;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        int i = int.Parse( ReadLine() ) - 1;
        int o = 0;

        while( i + o < s.Length && s[o] == s[i + o] ) {
            o++;
        }
        WriteLine( o );
        return;
    }
}
