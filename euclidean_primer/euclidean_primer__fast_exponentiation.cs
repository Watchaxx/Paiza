using static System.Console;

internal class Program
{
    static void Main()
    {
        ulong[] abm = System.Array.ConvertAll( ReadLine().Split(), ulong.Parse );
        ulong o = 1;

        while( 0 < abm[1] ) {
            if( ( abm[1] & 1 ) == 1 ) {
                o = o * abm[0] % abm[2];
            }
            abm[0] = abm[0] * abm[0] % abm[2];
            abm[1] >>= 1;
        }
        WriteLine( o );
        return;
    }
}
