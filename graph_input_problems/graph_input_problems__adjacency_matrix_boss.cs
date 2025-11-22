// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[,] m = new bool[n[0], n[0]];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            string[] t = ReadLine().Split();

            foreach( int j in Range( 0, n[0] ).Where( x => t[x] == "1" ) ) {
                m[i, j] = true;
            }
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            WriteLine( m[t[0], t[1]] && m[t[1], t[0]] ? 1 : 0 );
        }
        Out.Flush();
        return;
    }
}
