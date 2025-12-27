// 実行時間 290ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    const int Alph = 26;

    class Trie
    {
        internal Node Root = new Node();

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

        string a = t.GetLcp( ReadLine() );

        WriteLine( 0 < a.Length ? a : "#" );
        return;
    }
}
