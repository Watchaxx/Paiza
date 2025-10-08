// 実行時間 20ms
using System;

internal class Program
{
    static void Main()
    {
        int i = 0;
        int o = 0;
        int[] n = Array.ConvertAll( Console.ReadLine().Split(), int.Parse );
        int[] a = Array.ConvertAll( Console.ReadLine().Split(), int.Parse );

        while( i < n[0] ) {
            int j = i;

            while( j < n[0] && a[j] == n[1] ) {
                j++;
            }
            o += Math.Max( j - i - n[2] + 1, 0 );
            i = Math.Max( i + 1, j );
        }
        Console.WriteLine( o );
        return;
    }
}
