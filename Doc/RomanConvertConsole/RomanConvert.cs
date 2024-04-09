using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RomanConvertConsole
{
    public record class NumKey(string Fnum, int Dnum);

    public class RomanConvert
    {
        private static Dictionary<int, string> literals
        = new Dictionary<int, string>
        {
{1000,  "M"},
{ 900, "CM"},
{ 500,  "D"},
{ 400, "CD"},
{ 100,  "C"},
{  90, "XC"},
{  50,  "L"},
{  40, "XL"},
{  10,  "X"},
{   9, "IX"},
{   5,  "V"},
{   4, "IV"},
{   1,  "I"}
        };
        public string Solution(int n)
        {
            return literals.Aggregate(
              string.Empty,
              (result, next) =>
              {
                  while (n >= next.Key)
                  {
                      n -= next.Key;
                      result += next.Value;
                  }
                  return result;
              }
            );
        }
    }
}
