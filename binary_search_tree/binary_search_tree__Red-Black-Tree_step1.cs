// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class Node
    {
        internal char Color { get; set; }
        internal int Val { get; set; }
        internal Node Left { get; set; }
        internal Node Parent { get; set; }
        internal Node Right { get; set; }

        internal Node( int n )
        {
            Color = 'R';
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
            t = InsertRb( t, new Node( i ) );
        }
        Preorder( t );
        return;
    }

    static (Node, Node) Balance( Node n, Node r )
    {
        if( n == null || n.Color == 'B' ) {
            return (r, null);
        } else if( n.Parent == null ) {
            n.Color = 'B';
            return (r, null);
        } else if( n.Parent.Color == 'B' ) {
            return (r, null);
        }

        Node g = n.Parent.Parent;
        Node u = n.Parent == g.Right ? g.Left : g.Right;

        if( u != null && u.Color == 'R' ) {
            n.Parent.Color = 'B';
            n.Parent.Parent.Color = 'R';
            u.Color = 'B';
            return (r, g);
        } else {
            if( n.Parent == g.Left ) {
                if( n == n.Parent.Right ) {
                    r = RotateL( r, n.Parent );
                    n = n.Left;
                }
                n.Parent.Color = 'B';
                n.Parent.Parent.Color = 'R';
                r = RotateR( r, n.Parent.Parent );
            } else {
                if( n == n.Parent.Left ) {
                    r = RotateR( r, n.Parent );
                    n = n.Right;
                }
                n.Parent.Color = 'B';
                n.Parent.Parent.Color = 'R';
                r = RotateL( r, n.Parent.Parent );
            }
        }
        return (r, null);
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

    static Node InsertRb( Node r, Node n )
    {
        Node c = n;

        r = Insert( r, n );
        while( true ) {
            var nn = Balance( c, r );

            if( nn.Item2 == null ) {
                break;
            }
            c = nn.Item2;
        }
        while( r.Parent != null ) {
            r = r.Parent;
        }
        r.Color = 'B';
        return r;
    }

    static void Preorder( Node n )
    {
        if( n == null ) {
            return;
        }
        WriteLine( $"{n.Val} {n.Color}" );
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
