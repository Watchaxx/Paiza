// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    const int Alph = 26;

    class Trie
    {
        internal Node Root = new Node();

        internal void Insert( string s )
        {
            Node p = Root;

            foreach( char c in s ) {
                if( p.Child[c - 'a'] == null ) {
                    p.Child[c - 'a'] = new Node();
                }
                p = p.Child[c - 'a'];
            }
            p.IsEnd = true;
            return;
        }

        internal class Node
        {
            internal bool IsEnd = false;
            internal Node[] Child = new Node[Alph];
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] s = new string[n[0]];
        Trie t = new Trie();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            string x = ReadLine();

            s[i] = x;
            t.Insert( x );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] x = ReadLine().Split().Select( int.Parse ).ToArray();
            var o = new System.Collections.Generic.List<char>();
            Trie.Node p = t.Root;

            x[0]--;
            foreach( int i in Range( 0, x[1] ) ) {
                p = p.Child[s[x[0]][i] - 'a'];
            }
            foreach( int i in Range( 0, Alph ) ) {
                if( p.Child[i] != null ) {
                    o.Add( System.Convert.ToChar( i + 'a' ) );
                }
            }
            WriteLine( 0 < o.Count ? string.Join( "", o ) : "#" );
        }
        Out.Flush();
        return;
    }
}
