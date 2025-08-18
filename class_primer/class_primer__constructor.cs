using static System.Console;

internal class Program
{
    class Employee
    {
        int Num;
        string Name;

        internal Employee( int i, string s )
        {
            Num = i;
            Name = s;
        }

        internal int GetNum()
        {
            return Num;
        }

        internal string GetName()
        {
            return Name;
        }
    }

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<Employee>( n );

        for( int _ = 0; _ < n; _++ ) {
            string[] s = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s[0], "make", c ) == 0 ) {
                l.Add( new Employee( int.Parse( s[1] ), s[2] ) );
            } else if( string.Compare( s[0], "getnum", c ) == 0 ) {
                WriteLine( l[int.Parse( s[1] ) - 1].GetNum() );
            } else if( string.Compare( s[0], "getname", c ) == 0 ) {
                WriteLine( l[int.Parse( s[1] ) - 1].GetName() );
            }
        }
        return;
    }
}
