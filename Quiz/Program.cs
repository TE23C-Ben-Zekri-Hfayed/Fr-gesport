int points = 0 ;

Console.WriteLine("Welcome to the Quiz show! You will answer some questions and if you get all the answers right you win a prize!!");

Console.WriteLine("Question 1.");
Console.WriteLine("");
Console.WriteLine("In the movie, 'Back to the Future', which car did they use to time travel?");
Console.WriteLine();
Console.WriteLine("a) DMC Delorean  b) Plymouth Fury  c) Chevrolet Corvette");

String answer1 = Console.ReadLine();

if (answer1 == "a")
{
    points++;
    Console.Clear();
    Console.WriteLine("And that's CORRECT!!");
    Console.ReadLine();
}
else
{
    Console.Clear();
    Console.WriteLine("Oof, that's incorrect, but don't worry! You get a revival question in the end! If you answer 2/1");
    Console.ReadLine();
}
Console.Clear();
Console.WriteLine("Question 2!!");
Console.WriteLine("");
Console.WriteLine("In which year did the Titanic sink on its maiden voyage?");