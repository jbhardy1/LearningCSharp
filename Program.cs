Console.WriteLine("Hello, C#!"); //initial line from project creation


Random dice = new Random();
int roll = dice.Next(1, 7);
int target = 2;
while(roll != target){
    if(roll > target){
        Console.WriteLine($"Too high! {roll}");
        roll = dice.Next(1,7);
    }
    else if(roll < target){
        Console.WriteLine($"Too low! {roll}");
        roll = dice.Next(1,7);
    }
    else {
        Console.WriteLine($"Right on the money! {roll}");
    }
    
}