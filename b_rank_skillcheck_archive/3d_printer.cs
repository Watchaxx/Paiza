// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] xyz = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] o = new string[xyz[2]];

        foreach( int i in Range( 0, xyz[2] ) ) {
            char[] t = Repeat( '.', xyz[1] ).ToArray();

            foreach( int _ in Range( 0, xyz[0] ) ) {
                string r = ReadLine();

                foreach( int j in Range( 0, xyz[1] ) ) {
                    if( r[j] == '#' ) {
                        t[j] = '#';
                    }
                }
            }
            o[i] = string.Join( "", t );
            ReadLine();
        }
        WriteLine( string.Join( System.Environment.NewLine, o.Reverse() ) );
        return;
    }
}
