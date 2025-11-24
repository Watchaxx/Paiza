// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        const int a = 26;
        int n = int.Parse( ReadLine() );
        int[] li = new int[a];
        int[] lo = new int[a];

        foreach( int _ in Range( 0, n ) ) {
            string s = ReadLine();

            li[s[0] - 'a']++;
            lo[s.Last() - 'a']++;
        }
        foreach( int _ in Range( 0, a ).Where( x => li[x] != lo[x] ) ) {
            goto Nx;
        }
        WriteLine( 1 );
        return;
    Nx:
        if( Range( 0, a ).Where( x => li[x] == lo[x] + 1 ).Count() == 1 ) {
            if( Range( 0, a ).Where( x => li[x] + 1 == lo[x] ).Count() == 1 ) {
                if( Range( 0, a ).Where( x => li[x] == lo[x] ).Count() == a - 2 ) {
                    WriteLine( 1 );
                    return;
                }
            }
        }
        WriteLine( 0 );
        return;
    }
}
