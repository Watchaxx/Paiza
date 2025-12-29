// 実行時間 60ms
using static System.Console;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        int j = int.Parse( ReadLine() ) - 1;
        int[] p = new int[s.Length];

        System.Array.ConvertAll( ReadLine().Split(), int.Parse ).CopyTo( p, 0 );
        for( int i = j + 1; i < j + p[j]; i++ ) {
            p[i] = System.Math.Min( p[j - ( i - j )], j + p[j] - i );
        }
        WriteLine( string.Join( System.Environment.NewLine, p ) );
        return;
    }
}
