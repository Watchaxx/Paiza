// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, hw[0] ) ) {
            byte[] b = new byte[hw[1]];
            string s = ReadLine();

            foreach( int i in Range( 0, hw[1] ) ) {
                switch( s[i] ) {
                case '_':
                    b[i] = 0;
                    break;
                case '/':
                    b[i] = 1;
                    break;
                case '\\':
                    b[i] = 2;
                    break;
                }
            }
            WriteLine( string.Join( " ", b ) );
        }
        Out.Flush();
        return;
    }
}
