using System;
using System.Text;  //Unicode Encoding is here

namespace CopyrightTriangle
{
    class CopyrightTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode; //Without this encoding only letter C is displayed
            char copyright = '\u00A9';
            Console.WriteLine(@"   {0}
  {0} {0}
 {0}   {0}  
{0} {0} {0} {0}", copyright);
        }
    }
}
//Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
