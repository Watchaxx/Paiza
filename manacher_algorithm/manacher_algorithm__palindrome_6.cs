// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        int j = 0;
        int[] p = new int[s.Length];

        foreach( int i in Range( 0, s.Length ) ) {
            if( i < j + p[j] ) {
                p[i] = System.Math.Min( p[j - ( i - j )], j + p[j] - i );
            }
            if( j + p[j] <= i + p[i] ) {
                while( 0 <= i - p[i] && i + p[i] < s.Length && s[i - p[i]] == s[i + p[i]] ) {
                    p[i]++;
                }
                j = i;
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, p ) );
        return;
    }
}
