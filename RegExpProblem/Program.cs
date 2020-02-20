using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExpProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRLF stands for "Carriage Return / Line Feed"
            string names = "Michael James Clark Simpson\r\nWilson Thornwell Dunlap\r\nWilson Rawls\r\nOtis Wilson\r\nCarlos Dunlap\r\nKing David Dunlap Sr.\r\nKing David Dunlap, Jr\r\nKing David Dunlap III\r\nKing David Dunlap IV\r\nKing David Dunlap V\r\nKing David Dunlap VI\r\nKing David Dunlap VII\r\nKing David Dunlap VIII\r\nKing David Dunlap IX\r\nKing David Dunlap X\r\nKing David Dunlap XI\r\nKing David Dunlap XII\r\nKing David Dunlap XIII\r\nKing David Dunlap XIV\r\nKing David Dunlap XV\r\nKing David Dunlap XVI\r\nKing Richard V";

            string pattern = @"((^Wilson.*\r$)|(^.*Dunlap((,)? Sr(.)?|(,)? Jr(.)?| III| IV| V| VI| VII| VIII| IX| X| XI| XII| XIII| XIV| XV| XVI| XVII| XVIII| XIX| XX)?\r?$))";

            var b1 = Regex.Matches(names, pattern, RegexOptions.Multiline);

            var b2 = Regex.IsMatch(names, pattern, RegexOptions.Multiline);

            Console.WriteLine(names);

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
