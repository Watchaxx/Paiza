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

        internal void ChangeName( string s )
        {
            Name = s;
            return;
        }

        internal void ChangeNum( int i )
        {
            Num = i;
            return;
        }

        internal string GetName()
        {
            return Name;
        }

        internal int GetNum()
        {
            return Num;
        }
    }

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<Employee>( n );

        for( int _ = 0; _ < n; _++ ) {
            string[] s = ReadLine().Split();

            switch( s[0] ) {
            case "make":
                l.Add( new Employee( int.Parse( s[1] ), s[2] ) );
                break;
            case "getnum":
                WriteLine( l[int.Parse( s[1] ) - 1].GetNum() );
                break;
            case "getname":
                WriteLine( l[int.Parse( s[1] ) - 1].GetName() );
                break;
            case "change_num":
                l[int.Parse( s[1] ) - 1].ChangeNum( int.Parse( s[2] ) );
                break;
            case "change_name":
                l[int.Parse( s[1] ) - 1].ChangeName( s[2] );
                break;
            }
        }
        return;
    }
}
