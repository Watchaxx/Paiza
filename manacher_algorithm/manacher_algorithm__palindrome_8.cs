// 実行時間 40ms
using static System.Console;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        int[] o = new int[s.Length];
        var d = new System.Collections.Generic.Dictionary<char, char>() {
            { 'b', 'd' }, { 'd', 'b' }, { 'i', 'i' }, { 'l', 'l' },
            { 'm', 'm' }, { 'n', 'n' }, { 'o', 'o' }, { 'p', 'q' },
            { 'q', 'p' }, { 's', 'z' }, { 'z', 's' }, { 't', 't' },
            { 'u', 'u' }, { 'v', 'v' }, { 'w', 'w' }, { 'x', 'x' } };

        for( int i = 0, j = 0; i < s.Length; i++ ) {
            if( i < j + o[j] ) {
                o[i] = System.Math.Min( o[j - ( i - j )], j + o[j] - i );
            }
            if( j + o[j] <= i + o[i] ) {
                while( 0 <= i - o[i] && i + o[i] < s.Length && s[i - o[i]] == d[s[i + o[i]]] ) {
                    o[i]++;
                }
                j = i;
            }
            if( j + o[j] < i ) {
                j = i + 1;
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }
}
