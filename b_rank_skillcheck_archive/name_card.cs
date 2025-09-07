// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int i = 0;
        int[] nm = ReadLine().Split().Select( int.Parse ).ToArray();

        while( true ) {
            if( nm[0] * 2 * i + 1 <= nm[1] & nm[1] <= nm[0] * 2 * ( i + 1 ) ) {
                var l = new System.Collections.Generic.List<int>( nm[0] * 2 );

                foreach( int j in Range( 1, nm[0] * 2 ) ) {
                    l.Add( nm[0] * 2 * i + j );
                }

                int idx = l.IndexOf( nm[1] );

                l.Reverse();
                WriteLine( l[idx] );
                break;
            }
            i++;
        }
        return;
    }
}
