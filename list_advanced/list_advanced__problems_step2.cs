// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in b ) {
            var l = new System.Collections.Generic.List<int>();

            foreach( int j in a.Where( x => x % i != 0 ) ) {
                l.Add( j );
            }
            a = l.ToArray();
        }
        if( a.Length == 0 ) {
            WriteLine( "You" );
        } else {
            WriteLine( "Kyoko" );
            WriteLine( string.Join( " ", a ) );
        }
        return;
    }
}
