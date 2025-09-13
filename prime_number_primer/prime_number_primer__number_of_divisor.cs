using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 1;
        var l = new System.Collections.Generic.List<int>();

        for( int i = 2; i * i <= n; i++ ) {
            if( n % i != 0 ) {
                continue;
            }

            int e = 0;

            while( n % i == 0 ) {
                n /= i;
                e++;
            }
            l.Add( e );
        }
        if( n != 1 ) {
            l.Add( 1 );
        }
        foreach( int i in l ) {
            o *= i + 1;
        }
        WriteLine( o );
        return;
    }
}
