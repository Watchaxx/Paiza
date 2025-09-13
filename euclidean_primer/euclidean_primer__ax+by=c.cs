using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] abc = System.Array.ConvertAll( ReadLine().Split(), int.Parse );
        int x = 0;
        int y = 0;

        if( abc[0] < abc[1] ) {
            y = 1;
            x = ( abc[2] - abc[1] ) / abc[0];
        } else {
            x = 1;
            y = ( abc[2] - abc[0] ) / abc[1];
        }
        WriteLine( $"{x} {y}" );
        return;
    }
}
