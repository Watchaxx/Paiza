// 実行時間 1060ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, string>;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        int t = s.Length / 2;
        int[][] d = new int[t + 1][];
        Tpl[][] al = new Tpl[4][];

        foreach( int i in Range( 0, t + 1 ) ) {
            d[i] = Repeat( int.MaxValue, 4 ).ToArray();
        }
        d[0][0] = 0;
        al[0] = new Tpl[] { new Tpl( 0, "00" ), new Tpl( 2, "01" ) };
        al[1] = new Tpl[] { new Tpl( 0, "10" ), new Tpl( 2, "11" ) };
        al[2] = new Tpl[] { new Tpl( 1, "01" ), new Tpl( 3, "00" ) };
        al[3] = new Tpl[] { new Tpl( 1, "11" ), new Tpl( 3, "10" ) };
        foreach( int i in Range( 0, t ) ) {
            string ss = s.Substring( 2 * i, 2 );

            foreach( int j in Range( 0, 4 ).Where( x => d[i][x] != int.MaxValue ) ) {
                foreach( Tpl p in al[j] ) {
                    d[i + 1][p.Item1] = System.Math.Min( d[i + 1][p.Item1], d[i][j] + HammingD( p.Item2, ss ) );
                }
            }
        }
        WriteLine( d[t][0] );
        return;
    }

    static int HammingD( string s1, string s2 )
    {
        return Range( 0, s1.Length ).Where( x => s1[x] != s2[x] ).Count();
    }
}
