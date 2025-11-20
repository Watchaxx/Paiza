// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class Node
    {
        internal int Root { get; set; }
        internal Node Left { get; set; }
        internal Node Right { get; set; }

        internal Node( int n )
        {
            Root = n;
            Left = null;
            Right = null;
        }
    }

    static List<int> l;

    static void Main()
    {
        Node t = null;

        l = new List<int>( int.Parse( ReadLine() ) );
        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            t = Insert( t, new Node( i ) );
        }
        Preorder( t );

        int[] a = l.ToArray();

        ReadLine();
        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            int j = System.Array.IndexOf( a, i );

            WriteLine( 0 <= j ? j + 1 : -1 );
        }
        return;
    }

    static Node Insert( Node r, Node n )
    {
        if( r == null ) {
            return n;
        }
        if( n.Root < r.Root ) {
            r.Left = Insert( r.Left, n );
        } else {
            r.Right = Insert( r.Right, n );
        }
        return r;
    }

    static void Preorder( Node n )
    {
        if( n == null ) {
            return;
        }
        l.Add( n.Root );
        Preorder( n.Left );
        Preorder( n.Right );
        return;
    }
}
