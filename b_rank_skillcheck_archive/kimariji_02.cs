// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        ReadLine();
        string s1 = ReadLine();
        string s2 = ReadLine();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, System.Math.Min( s1.Length, s2.Length ) ) ) {
            WriteLine( s1[i] == s2[i] ? "Yes" : "No" );
        }
        Out.Flush();
        return;
    }
}
