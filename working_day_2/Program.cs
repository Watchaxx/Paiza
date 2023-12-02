using System;
using static System.Console;

internal class Program
{
    static void Main()
    {
        string[] rl = ReadLine().Split( ' ' );
        bool w = false;
        var dt = new DateTime( 2019, int.Parse( rl[0] ), int.Parse( rl[1] ) ).AddDays( 1d );

        while( w != true ) {
            w = IsWork( dt );
            if( w != true ) {
                dt = dt.AddDays( 1d );
            }
        }
        WriteLine( $"{dt.Month}月{dt.Day}日" );
        return;
    }

    static bool IsWork( DateTime dt )
    {
        if( dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday ) {
            return false;
        }
        switch( dt.Month ) {
        case 1:
            switch( dt.Day ) {
            case 1:
            case 14:
                return false;
            }
            break;
        case 2:
            if( dt.Day == 11 ) {
                return false;
            }
            break;
        case 3:
            if( dt.Day == 21 ) {
                return false;
            }
            break;
        case 4:
            switch( dt.Day ) {
            case 29:
            case 30:
                return false;
            }
            break;
        case 5:
            switch( dt.Day ) {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                return false;
            }
            break;
        case 7:
            if( dt.Day == 15 ) {
                return false;
            }
            break;
        case 8:
            switch( dt.Day ) {
            case 11:
            case 12:
                return false;
            }
            break;
        case 9:
            switch( dt.Day ) {
            case 16:
            case 23:
                return false;
            }
            break;
        case 10:
            switch( dt.Day ) {
            case 14:
            case 22:
                return false;
            }
            break;
        case 11:
            switch( dt.Day ) {
            case 3:
            case 4:
            case 23:
                return false;
            }
            break;
        }
        return true;
    }
}
