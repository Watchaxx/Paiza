// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] s = new string[n];

        foreach( int i in Range( 0, n ) ) {
            s[i] = ReadLine();
        }
        WriteLine( string.Join( "_", s ) );
        return;
    }
}
