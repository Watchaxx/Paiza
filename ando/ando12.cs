// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static void Main()
    {
        int[] xyzn = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] m = new int[] { xyzn[0], xyzn[1] };
        Lst[] l = new Lst[2];

        l[0] = new Lst() { 0, xyzn[0] };
        l[1] = new Lst() { 0, xyzn[1] };
        foreach( int _ in Range( 0, xyzn[3] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            l[t[0]].Add( t[1] );
        }
        foreach( int i in Range( 0, 2 ) ) {
            l[i].Sort();
            foreach( int j in Range( 1, l[i].Count - 1 ) ) {
                m[i] = new[] { m[i], l[i][j] - l[i][j - 1] }.Min();
            }
        }
        WriteLine( m[0] * m[1] * xyzn[2] );
        return;
    }
}
