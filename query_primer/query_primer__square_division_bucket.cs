using System.Linq;
using static System.Console;
using static System.Math;

internal class Program
{
    static void Main()
    {
        const int num = 10000;
        int rem = num;
        int sq = (int)Sqrt( num );

        foreach( int _ in Enumerable.Range( 0, (int)Ceiling( (decimal)num / sq ) ) ) {
            int[] a = new int[Min( rem, sq )];

            foreach( int i in Enumerable.Range( 0, Min( rem, sq ) ) ) {
                a[i] = int.Parse( ReadLine() );
                rem--;
            }
            WriteLine( a.Max() );
        }
        return;
    }
}
