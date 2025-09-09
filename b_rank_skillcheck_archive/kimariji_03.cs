// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        int o = 0;
        string s1 = ReadLine();
        string s2 = ReadLine();

        for( int i = 0; i < System.Math.Min( s1.Length, s2.Length ); i++ ) {
            if( s1[i] == s2[i] ) {
                o++;
            } else {
                break;
            }
        }
        WriteLine( o );
        return;
    }
}
