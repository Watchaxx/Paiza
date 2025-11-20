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
        Node t = null;

        ReadLine();
        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            t = Insert( t, new Node( i ) );
        }
        ReadLine();
        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            t = Remove( i, t );
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

    static Node Search( int v, Node n )
    {
        if( n == null || n.Root == v ) {
            return n;
        }
        return v < n.Root ? Search( v, n.Left ) : Search( v, n.Right );
    }

    static Node Remove( int v, Node n )
    {
        if( n == null ) {
            return n;
        } else if( v < n.Root ) {
            n.Left = Remove( v, n.Left );
        } else if( n.Root < v ) {
            n.Right = Remove( v, n.Right );
        } else {
            if( n.Left == null ) {
                return n.Right;
            } else if( n.Right == null ) {
                return n.Left;
            } else {
                Node m = n.Right;

                while( m.Left != null ) {
                    m = m.Left;
                }
                n.Root = m.Root;
                n.Right = Remove( m.Root, n.Right );
            }
        }
        return n;
    }
}
