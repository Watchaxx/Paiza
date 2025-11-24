// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        const int a = 26;
        int[] li = new int[a];
        int[] lo = new int[a];

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            string s = ReadLine();

            li[s[0] - 'a']++;
            lo[s.Last() - 'a']++;
        }
        if( Range( 0, a ).All( x => li[x] == lo[x] ) ) {
            WriteLine( 1 );
            return;
        }
        if( Range( 0, a ).Count( x => li[x] == lo[x] + 1 ) == 1
            && Range( 0, a ).Count( x => li[x] + 1 == lo[x] ) == 1
            && Range( 0, a ).Count( x => li[x] == lo[x] ) == a - 2 ) {
            WriteLine( 1 );
            return;
        }
        WriteLine( 0 );
        return;
    }
}
