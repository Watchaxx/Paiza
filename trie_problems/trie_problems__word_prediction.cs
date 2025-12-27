// 実行時間 270ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    const int Alph = 26;

    class Trie
    {
        internal Node Root = new Node();

        void Dfs( List<char> s, List<string> l, Node p )
        {
            if( p.IsEnd == true ) {
                l.Add( string.Join( "", s ) );
            }
            foreach( int i in Range( 0, Alph ) ) {
                if( p.Child[i] != null ) {
                    s.Add( System.Convert.ToChar( i + 'a' ) );
                    Dfs( s, l, p.Child[i] );
                    s.RemoveAt( s.Count - 1 );
                }
            }
            return;
        }

        internal void Erase( string s )
        {
            Node p = Root;
            var k = new Stack<Node>();

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

        internal string GetLcp( string s )
        {
            var r = new List<char>();
            Node p = Root;

            foreach( char c in s ) {
                if( p.Child[c - 'a'] == null ) {
                    break;
                }
                r.Add( c );
                p = p.Child[c - 'a'];
            }
            return string.Join( "", r );
        }

        internal List<string> GetWord( string s )
        {
            var c = new List<char>();
            var r = new List<string>();
            Node p = Root;

            foreach( char a in s ) {
                if( p.Child[a - 'a'] == null ) {
                    return r = new List<string>() { s };
                }
                p = p.Child[a - 'a'];
            }
            Dfs( s.ToList(), r, p );
            return r;
        }

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
        int n = int.Parse( ReadLine() );
        Trie t = new Trie();

        foreach( int _ in Range( 0, n ) ) {
            t.Insert( ReadLine() );
        }
        WriteLine( string.Join( System.Environment.NewLine, t.GetWord( ReadLine() ) ) );
        return;
    }
}
