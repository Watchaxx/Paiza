// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    const int Alph = 26;

    class Node
    {
        internal Node[] Child;

        internal Node()
        {
            Child = new Node[Alph];
        }
    }

    static void Main()
    {
        string s = ReadLine();
        int q = int.Parse( ReadLine() );
        char[] o = Repeat( '#', q ).ToArray();
        Node[] trie = new Node[s.Length + 1];

        foreach( int i in Range( 0, s.Length + 1 ) ) {
            trie[i] = new Node();
        }
        foreach( int i in Range( 0, s.Length ) ) {
            trie[i].Child[s[i] - 'a'] = trie[i + 1];
        }
        foreach( int i in Range( 0, q ) ) {
            int x = int.Parse( ReadLine() );

            foreach( int j in Range( 0, Alph ) ) {
                if( trie[x].Child[j] != null ) {
                    o[i] = System.Convert.ToChar( j + 'a' );
                    break;
                }
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }
}
