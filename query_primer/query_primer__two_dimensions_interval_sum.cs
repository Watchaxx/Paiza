using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hwn = ReadLine().Split().Select( int.Parse ).ToArray();
        int[,] a = new int[hwn[0], hwn[1]];
        int[,] s = new int[hwn[0] + 1, hwn[1] + 1];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, hwn[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int j in Range( 0, hwn[1] ) ) {
                a[i, j] = t[j];
            }
        }
        foreach( int i in Range( 0, hwn[0] ) ) {
            s[i, 0] = 0;
            foreach( int j in Range( 0, hwn[1] ) ) {
                s[i + 1, j + 1] = s[i + 1, j] + s[i, j + 1] - s[i, j] + a[i, j];
            }
        }
        foreach( int _ in Range( 0, hwn[2] ) ) {
            int[] abcd = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
            int lt = s[abcd[0], abcd[1]];
            int lb = s[abcd[2] + 1, abcd[1]];
            int rt = s[abcd[0], abcd[3] + 1];
            int rb = s[abcd[2] + 1, abcd[3] + 1];

            WriteLine( rb - rt - lb + lt );
        }
        Out.Flush();
        return;
    }
}
