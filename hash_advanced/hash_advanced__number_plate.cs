// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        string s1 = ReadLine();
        int i1 = int.Parse( ReadLine() );
        string s2 = ReadLine();
        int i2 = int.Parse( ReadLine() );
        WriteLine( ( Func( s1 ) * i1 + Func( s2 ) * i2 ) % 1000 );
        return;
    }

    static int Func( string s )
    {
        int i = 0;

        foreach( char c in s ) {
            i += c;
        }
        return i;
    }
}
