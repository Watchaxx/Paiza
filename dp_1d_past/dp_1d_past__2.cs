// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        string s = ReadLine();

        foreach( int i in Range( 0, s.Length ) ) {
            int l = i;
            int r = i;

            while( 0 <= l && r < s.Length ) {
                if( s[l] != s[r] ) {
                    break;
                }
                o++;
                l--;
                r++;
            }
        }
        foreach( int i in Range( 0, s.Length - 1 ) ) {
            int l = i;
            int r = i + 1;

            while( 0 <= l && r < s.Length ) {
                if( s[l] != s[r] ) {
                    break;
                }
                o++;
                l--;
                r++;
            }
        }
        WriteLine( o );
        return;
    }
}
