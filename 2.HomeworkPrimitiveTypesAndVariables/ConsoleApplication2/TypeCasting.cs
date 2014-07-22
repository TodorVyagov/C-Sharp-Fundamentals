using System;

class TypeCasting
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World!";
        object combinedWords = word1 + " " + word2;
        string castObject = (string) combinedWords;
        Console.WriteLine(castObject);
    }
}
//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
