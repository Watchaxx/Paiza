// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class Node
    {
        internal int Val { get; set; }
        internal Node Left { get; set; }
        internal Node Parent { get; set; }
        internal Node Right { get; set; }

        internal Node( int n )
        {
            Val = n;
            Left = null;
            Parent = null;
            Right = null;
        }
    }

    static void Main()
    {
        Node t = null;

        ReadLine();
        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            t = InsertAvl( t, new Node( i ) );
        }
        ReadLine();
        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            t = RemoveAvl( i, t );
        }
        Preorder( t );
        return;
    }

    static Node Balance( Node n, Node r )
    {
        if( n == null ) {
            return r;
        }

        int t = Height( n.Left ) - Height( n.Right );

        if( 1 < t ) {
            if( Height( n.Left.Left ) < Height( n.Left.Right ) ) {
                r = RotateL( r, n.Left );
            }
            return RotateR( r, n );
        } else if( t < -1 ) {
            if( Height( n.Right.Right ) < Height( n.Right.Left ) ) {
                r = RotateR( r, n.Right );
            }
            return RotateL( r, n );
        }
        return r;
    }

    static int Height( Node n )
    {
        if( n == null ) {
            return 0;
        }

        int l = Height( n.Left );
        int r = Height( n.Right );

        return new[] { l, r }.Max() + 1;
    }

    static Node Insert( Node r, Node n )
    {
        if( r == null ) {
            return n;
        }
        if( n.Val < r.Val ) {
            r.Left = Insert( r.Left, n );
            r.Left.Parent = r;
        } else {
            r.Right = Insert( r.Right, n );
            r.Right.Parent = r;
        }
        return r;
    }

    static Node InsertAvl( Node r, Node n )
    {
        Node c = n;

        r = Insert( r, n );
        while( c != null ) {
            r = Balance( c, r );
            c = c.Parent;
        }
        return r;
    }

    static void Preorder( Node n )
    {
        if( n == null ) {
            return;
        }
        WriteLine( n.Val );
        Preorder( n.Left );
        Preorder( n.Right );
        return;
    }

    static Node Remove( int v, Node n )
    {
        if( n == null ) {
            return n;
        } else if( v < n.Val ) {
            n.Left = Remove( v, n.Left );
        } else if( n.Val < v ) {
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
                n.Val = m.Val;
                n.Right = Remove( m.Val, n.Right );
            }
        }
        return n;
    }

    static Node RemoveAvl( int v, Node n )
    {
        Node c = null;
        Node t = Search( v, n );

        if( t == null ) {
            return n;
        }
        if( t.Left != null && t.Right != null ) {
            Node s = t.Right;

            while( s.Left != null ) {
                s = s.Left;
            }
            c = s.Parent;
        } else {
            c = t.Parent;
        }
        n = Remove( v, n );
        while( c != null ) {
            n = Balance( c, n );
            c = c.Parent;
        }
        return n;
    }

    static Node RotateL( Node r, Node n )
    {
        if( n == null || n.Right == null ) {
            return r;
        }

        Node t = n.Right;

        n.Right = t.Left;
        if( t.Left != null ) {
            t.Left.Parent = n;
        }
        t.Parent = n.Parent;
        if( n.Parent == null ) {
            r = t;
        } else if( n == n.Parent.Left ) {
            n.Parent.Left = t;
        } else {
            n.Parent.Right = t;
        }
        t.Left = n;
        n.Parent = t;
        return r;
    }

    static Node RotateR( Node r, Node n )
    {
        if( n == null || n.Left == null ) {
            return r;
        }

        Node t = n.Left;

        n.Left = t.Right;
        if( t.Right != null ) {
            t.Right.Parent = n;
        }
        t.Parent = n.Parent;
        if( n.Parent == null ) {
            r = t;
        } else if( n == n.Parent.Left ) {
            n.Parent.Left = t;
        } else {
            n.Parent.Right = t;
        }
        t.Right = n;
        n.Parent = t;
        return r;
    }

    static Node Search( int v, Node n )
    {
        if( n == null || n.Val == v ) {
            return n;
        }
        return v < n.Val ? Search( v, n.Left ) : Search( v, n.Right );
    }
}
