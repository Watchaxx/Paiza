// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    const int Alph = 26;

    class Trie
    {
        internal Node Root = new Node();

        internal uint CountPrefix( string s )
        {
            Node p = Root;

            foreach( char c in s ) {
                if( p.Child[c - 'a'] == null ) {
                    return 0;
                }
                p = p.Child[c - 'a'];
            }
            return p.Rec;
        }

        internal void Erase( string s )
        {
            Node p = Root;
            var k = new System.Collections.Generic.Stack<Node>();

            k.Push( p );
            foreach( char c in s ) {
                if( p.Child[c - 'a'] == null ) {
                    return;
                }
                p = p.Child[c - 'a'];
                k.Push( p );
            }
            p.IsEnd = false;
            do {
                p = k.Pop();
                if( p.IsEnd == true ) {
                    return;
                }
                if( p.Child.Any( x => x != null ) == true ) {
                    return;
                }
                p = null;
                k.Peek().Child[s[s.Length - 1] - 'a'] = null;
                s = s.Substring( 0, s.Length - 1 );
            } while( 0 < s.Length );
            return;
        }

        internal void Insert( string s )
        {
            Node p = Root;

            p.Rec++;
            foreach( char c in s ) {
                if( p.Child[c - 'a'] == null ) {
                    p.Child[c - 'a'] = new Node();
                }
                p = p.Child[c - 'a'];
                p.Rec++;
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
            internal uint Rec = 0;
            internal Node[] Child = new Node[Alph];
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        Trie t = new Trie();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, n[0] ) ) {
            t.Insert( ReadLine() );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            WriteLine( t.CountPrefix( ReadLine() ) );
        }
        Out.Flush();
        return;
    }
}
