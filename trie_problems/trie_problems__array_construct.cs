// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Dic = System.Collections.Generic.Dictionary<char, char>;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        char t = 'a';
        char[] o = new char[n[1]];
        string s = ReadLine();
        Dic[] trie = new Dic[n[0] + 1];

        foreach( int i in Range( 0, n[0] ) ) {
            trie[i] = new Dic() { { t, s[i] } };
            t = s[i];
        }
        trie[n[0]] = new Dic();
        foreach( int i in Range( 0, n[1] ) ) {
            string[] q = ReadLine().Split();
            int x = int.Parse( q[0] );

            o[i] = trie[x].ContainsKey( q[1][0] ) ? trie[x][q[1][0]] : '#';
        }
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }
}
