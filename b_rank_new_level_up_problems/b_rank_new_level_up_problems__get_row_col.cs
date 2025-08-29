// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        bool[,] b = new bool[hw[0], hw[1]];
        var sb = new System.Text.StringBuilder();

        foreach( int i in Range( 0, hw[0] ) ) {
            string s = ReadLine();

            foreach( int j in Range( 0, hw[1] ) ) {
                b[i, j] = s[j] == '#';
            }
        }

        int[] yx = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, hw[0] ) ) {
            foreach( int j in Range( 0, hw[1] ) ) {
                if( i + j == yx[0] + yx[1] | i - j == yx[0] - yx[1] | i == yx[0] | j == yx[1] ) {
                    b[i, j] = !b[i, j];
                }
            }
        }
        foreach( int i in Range( 0, hw[0] ) ) {
            foreach( int j in Range( 0, hw[1] ) ) {
                sb.Append( b[i, j] ? '#' : '.' );
            }
            sb.AppendLine();
        }
        WriteLine( sb );
    }
}
