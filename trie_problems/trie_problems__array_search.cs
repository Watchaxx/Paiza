// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Dic = System.Collections.Generic.Dictionary<char, char>;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() ) + 1;
        char[] o = new char[n];
        Dic[] trie = new Dic[n];

        foreach( int i in Range( 0, n ) ) {
            trie[i] = new Dic();
        }
        foreach( int i in Range( 0, n ) ) {
            string[] q = ReadLine().Split();

            trie[int.Parse( q[0] )].Add( q[1][0], q[2][0] );
        }
        WriteLine( string.Join( "", Range( 0, n - 1 ).Select( x => trie[x].Values.First() ) ) );
        return;
    }
}
