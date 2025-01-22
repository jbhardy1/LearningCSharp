// Console.WriteLine("Hello, C#!"); //initial line from project creation


// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){

//     if((roll1 == roll2) && (roll2 == roll3)){
//         total += 6;
//         Console.WriteLine($"You rolled triples! +6 bonus to total! \nNew Total: {total}");
//     }
//     else{
//         total += 2;
//         Console.WriteLine($"You rolled doubles! +2 bonus to total! \nNew total: {total}");
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }

// else if(total >= 10){
//     Console.WriteLine("You win a new Laptop!");
// }

// else if(total == 7){
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10  && daysUntilExpiration > 0){
    Console.WriteLine("Your subscription expires soon. Renew now!");
    Console.WriteLine(daysUntilExpiration);

    if(daysUntilExpiration <= 5 && daysUntilExpiration > 1){
        discountPercentage = 10;
        Console.WriteLine($"Renew now and save {discountPercentage}%");
    }

    else if(daysUntilExpiration == 1){
        discountPercentage = 20;
        Console.WriteLine($"Renew now and save {discountPercentage}%");
    }
}

else if (daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired");
}

else {
    //do nothing
}