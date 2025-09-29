// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nq = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = new int[nq[0]];

        foreach( int _ in Range( 0, nq[1] ) ) {
            string[] s = ReadLine().Split();
            int i = int.Parse( s[1] ) - 1;

            if( b[i] == 0 && s[0][0] == 'A' ) {
                b[i] = 1;
            } else if( b[i] == 0 && s[0][0] == 'B' ) {
                b[i] = -1;
            }
        }
        WriteLine( 0 < b.Sum() ? "A" : b.Sum() < 0 ? "B" : "Draw" );
        return;
    }
}
