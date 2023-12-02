using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] HW = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        string[] m = new string[HW[0]];

        foreach( int i in Enumerable.Range( 0, HW[0] ) ) {
            m[i] = ReadLine();
        }
        foreach( int i in Enumerable.Range( 0, HW[0] ) ) {
            foreach( int j in Enumerable.Range( 0, HW[1] ) ) {
                byte b = 0;

                if( m[i][j] == '.' ) {
                    foreach( int y in Enumerable.Range( i - 1, 3 ) ) {
                        foreach( int x in Enumerable.Range( j - 1, 3 ) ) {
                            try {
                                if( m[y][x] == '#' ) {
                                    b++;
                                }
                            } catch( System.IndexOutOfRangeException ) {
                            }
                        }
                    }
                    char[] c = m[i].ToCharArray();

                    c[j] = System.Convert.ToChar( $"{b}" );
                    m[i] = string.Join( "", c );
                }
            }
        }
        WriteLine( string.Join( "\n", m ) );
        return;
    }
}
