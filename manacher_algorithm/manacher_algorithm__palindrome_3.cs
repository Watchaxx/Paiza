// 実行時間 80ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string s = ReadLine();

        foreach( int i in Range( 0, s.Length ) ) {
            char[] a = s.Substring( 0, i + 1 ).Reverse().ToArray();
            char[] b = s.Substring( i ).ToCharArray();
            int o = 0;

            foreach( int j in Range( 0, System.Math.Min( a.Length, b.Length ) ) ) {
                if( a[j] == b[j] ) {
                    o++;
                } else {
                    break;
                }
            }
            WriteLine( o );
        }
        return;
    }
}
