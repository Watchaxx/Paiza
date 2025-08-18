using static System.Console;

internal class Program
{
    class Employee
    {
        internal int Num;
        internal string Name;

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
                Employee e = new Employee() {
                    Num = int.Parse( s[1] ),
                    Name = s[2]
                };
                l.Add( e );
            } else if( string.Compare( s[0], "getnum", c ) == 0 ) {
                WriteLine( l[int.Parse( s[1] ) - 1].GetNum() );
            } else if( string.Compare( s[0], "getname", c ) == 0 ) {
                WriteLine( l[int.Parse( s[1] ) - 1].GetName() );
            }
        }
        return;
    }
}
