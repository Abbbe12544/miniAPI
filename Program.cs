using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Välkommen till vår räkneapplikation!");

app.MapGet("/add", (int num1, int num2) => AddNumbers(num1, num2));
app.MapGet("/subtract", (int num1, int num2) => SubtractNumbers(num1, num2));
app.MapGet("/division", (int num1, int num2) => DivideNumbers(num1, num2));
app.MapGet("/multiplication", (int num1, int num2) => MultiplyNumbers(num1, num2));
app.MapPost("/square", ([FromBody] int sideLength) => CalculateSquareArea(sideLength));

app.Run();

string AddNumbers(int num1, int num2)
{
    return $"Summan av {num1} och {num2} = {num1 + num2}.";
}

string SubtractNumbers(int num1, int num2)
{
    return $"Skillnaden mellan {num1} och {num2} = {num1 - num2}.";
}

string DivideNumbers(int num1, int num2)
{
    if (num2 == 0)
        return "Division med noll är inte tillåten.";
    return $"Kvoten av {num1} och {num2} = {num1 / num2}.";
}

string MultiplyNumbers(int num1, int num2)
{
    return $"Produkten av {num1} och {num2} = {num1 * num2}.";
}

double CalculateSquareArea(int sideLength)
{
    return Math.Pow(sideLength, 2);
}

//hejda//
