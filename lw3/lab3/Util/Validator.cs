using System;

namespace lab3.Util
{
    public static class Validator
    {
        public static int[] GetArgsIntArrFromSrtArr(string[] args)
        {
            if (args.Length < 3)
            {
                throw new ArgumentException( "Число аргументов не менее трех" );
            }

            return new int [] { GetIntValueFromString( args [ 0 ] ), GetIntValueFromString( args [ 1 ] ), GetIntValueFromString( args [ 2 ] ) };            
        }

        private static int GetIntValueFromString(string value)
        {
            if (int.TryParse(value, out int result))
            {
                return result;
            }
            throw new ArgumentException( $"Значение: {value} не является числом" );
        }
    }
}
