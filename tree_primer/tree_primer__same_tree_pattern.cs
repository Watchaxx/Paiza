// 実行時間 50ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n1 = int.Parse( ReadLine() );
        var g1 = new List<int>[n1];

        foreach( int i in Range( 0, n1 ) ) {
            g1[i] = new List<int>( n1 );
        }
        foreach( int _ in Range( 0, n1 - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g1[a[0]].Add( a[1] );
            g1[a[1]].Add( a[0] );
        }

        int n2 = int.Parse( ReadLine() );
        var g2 = new List<int>[n2];

        foreach( int i in Range( 0, n2 ) ) {
            g2[i] = new List<int>( n2 );
        }
        foreach( int _ in Range( 0, n2 - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g2[a[0]].Add( a[1] );
            g2[a[1]].Add( a[0] );
        }
        if( n1 != n2 ) {
            WriteLine( "NO" );
            return;
        }

        var p = new List<int[]>();

        Permutation( p, Range( 0, n1 ).ToList(), 0 );
        foreach( int[] i in p ) {
            bool b = true;
            int j = 0;
            var d = new Dictionary<int, int>( i.Length );

            foreach( int k in i ) {
                d.Add( k, j );
                j++;
            }
            foreach( int k in Range( 0, n1 ).Where( k => g1[k].Count != g2[d[k]].Count ) ) {
                b = false;
                break;
            }
            if( b == true ) {
                WriteLine( "YES" );
                return;
            }
        }
        WriteLine( "NO" );
        return;
    }

    /// <summary>
    /// 【C#アルゴリズム】全探索_順列列挙とは
    /// https://zenn.dev/student_blog/articles/10f359f0535f28
    /// </summary>
    /// <param name="p">結果のリスト</param>
    /// <param name="t">元のリスト</param>
    /// <param name="s">開始位置</param>
    static void Permutation( List<int[]> p, List<int> t, int s )
    {
        for( int i = s; i < t.Count; i++ ) {
            Swap( t, i, s );
            Permutation( p, t, s + 1 );
            Swap( t, i, s );
        }
        if( s == t.Count - 1 ) {
            p.Add( t.ToArray() );
        }
        return;
    }

    static void Swap( List<int> l, int i, int j )
    {
        // (l[i], l[j]) = (l[j], l[i]);
        int t = l[i];
        l[i] = l[j];
        l[j] = t;
        return;
    }
}
