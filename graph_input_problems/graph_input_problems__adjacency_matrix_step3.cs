// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        bool[][] m = new bool[n][];
        var l = new System.Collections.Generic.List<(int, int)>();

        foreach( int i in Range( 0, n ) ) {
            m[i] = new bool[n];
        }
        foreach( int i in Range( 0, n ) ) {
            string[] t = ReadLine().Split();

            foreach( int j in Range( 0, n ).Where( x => t[x] == "1" ) ) {
                m[i][j] = true;
                l.Add( (i, j) );
            }
        }
        foreach( var p in l.Where( x => m[x.Item1][x.Item2] && m[x.Item2][x.Item1] ) ) {
            o++;
            m[p.Item2][p.Item1] = false;
        }
        WriteLine( o );
        return;
    }
}
