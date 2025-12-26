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

        internal bool Search( string s )
        {
            Node p = Root;

            foreach( char c in s ) {
                if( p.Child[c - 'a'] == null ) {
                    return false;
                }
                p = p.Child[c - 'a'];
            }
            return p.IsEnd;
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
        Trie t = new Trie();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            t.Insert( ReadLine() );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            WriteLine( t.Search( ReadLine() ) ? "Yes" : "No" );
        }
        Out.Flush();
        return;
    }
}
