// 実行時間 20ms
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

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        Node t = null;

        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            t = Insert( t, new Node( i ) );
        }
        Preorder( t );
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
        WriteLine( n.Root );
        Preorder( n.Left );
        Preorder( n.Right );
        return;
    }
}
