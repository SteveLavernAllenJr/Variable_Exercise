// See https://aka.ms/new-console-template for more information


// Variable Declarations
string dogName;
int dogAge;
char myCharacter;
bool isAlive;
decimal dogCosts;
double otherDogCosts;

// Variable Initializations

dogName = "Peanut";
dogAge = 7;
myCharacter = '@';
isAlive = false;
dogCosts = 20.0m;
otherDogCosts = 20;

// Variable Interpolate
Console.WriteLine($"My dog's name is {dogName}, he is {dogAge} years old. I bought {dogName} for about ${dogCosts} in the year 2020.");
Console.WriteLine($"Even though {dogName} costs {myCharacter} ${otherDogCosts}, he was a good boy.");
Console.WriteLine($"It is {isAlive} that my {dogName} was violent, he just had a temper!");