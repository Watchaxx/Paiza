// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        decimal co = 0m;
        decimal yu = 0m;

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            switch( t[0] ) {
            case 1:
                yu += t[1];
                break;
            case 2:
                co += t[1];
                break;
            case 3:
                decimal tco = co - t[1] * co / ( co + yu );
                decimal tyu = yu - t[1] * yu / ( co + yu );

                co = tco;
                yu = tyu;
                break;
            }
        }
        WriteLine( (int)( 100 * co / ( co + yu ) ) );
        return;
    }
}
