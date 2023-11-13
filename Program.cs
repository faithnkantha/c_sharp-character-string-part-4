using System;
class QuestionFive
{
    static void Main()
    {
        char letter;
       
        Console.WriteLine("input a character");

        letter=Convert.ToChar(Console.ReadLine());

        if (char.IsLetter(letter))
        {
            if (char.IsUpper(letter))
                Console.WriteLine($"{letter} in lower case is {char.ToLower(letter)}");
            else 
                Console.WriteLine($"{letter} in upper case is {char.ToUpper(letter)}");
        }
        else
            Console.WriteLine("input a letter");
    }
}
