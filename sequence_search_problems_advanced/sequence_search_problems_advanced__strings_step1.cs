// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        int[] a = new int[26];

        foreach( char c in s ) {
            a[c - 'a']++;
        }
        WriteLine( string.Join( System.Environment.NewLine, a ) );
        return;
    }
}
