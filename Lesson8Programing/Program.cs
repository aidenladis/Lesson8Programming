
// example of a basic array
/*
string[] question = new string [3];
question[0] = "What is the capital of France?";
question[1] = "What is 2 + 2?";
question[2] = "What is the largest planet in our solar system?";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(question[i]);
}


// these are the smae thing the bottom one faster tho
foreach (string q in question)
{
    Console.WriteLine(q);
}
*/





//example of 2d array so it has 2 number like a 
string[,] questions = new string[4,2];

questions[0, 0] = "What is the capital of France?";
questions[0, 1] = "Paris";

questions[1, 0] = "What is 2 + 2?";
questions[1, 1] = "4";

questions[2, 0] = "What is the largest planet in our solar system?";
questions[2, 1] = "Jupiter";

questions[3, 0] = "What is the chemical symbol for water?";
questions[3, 1] = "H2O";

int correct = 0;
for (int i = 0; i < questions.GetLength(0); i++)
{
    Console.WriteLine(questions[i, 0]);
    string answer = Console.ReadLine();

    if (answer.ToLower() == questions[i, 1].ToLower())//(.ToLower()) makes it so that the answer is not case sensitive
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!\n");
        correct++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("WRONG!.\n");
    }

    // this resets the color back to white
    Console.ResetColor();
}

//show score
Console.WriteLine($"You got {correct} out of {questions.GetLength(0)} questions correct.");


//feedback on your score%

double percentage = (double)correct / questions.GetLength(0) * 100;

if (percentage >= 75)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You scored " + percentage + "%.");
}
else if (percentage >= 50)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You scored " + percentage + "%.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You scored " + percentage + "%");
}
Console.ResetColor();