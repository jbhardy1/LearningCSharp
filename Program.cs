// // Console.WriteLine("Hello, C#!"); //initial line from project creation

// // Random dice = new Random();

// // int roll1 = dice.Next(1, 7);
// // int roll2 = dice.Next(1, 7);
// // int roll3 = dice.Next(1, 7);

// // int total = roll1 + roll2 + roll3;

// // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){

// //     if((roll1 == roll2) && (roll2 == roll3)){
// //         total += 6;
// //         Console.WriteLine($"You rolled triples! +6 bonus to total! \nNew Total: {total}");
// //     }
// //     else{
// //         total += 2;
// //         Console.WriteLine($"You rolled doubles! +2 bonus to total! \nNew total: {total}");
// //     }
// // }

// // if (total >= 16)
// // {
// //     Console.WriteLine("You win a new car!");
// // }

// // else if(total >= 10){
// //     Console.WriteLine("You win a new Laptop!");
// // }

// // else if(total == 7){
// //     Console.WriteLine("You win a trip for two!");
// // }
// // else
// // {
// //     Console.WriteLine("Sorry, you lose.");
// // }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration <= 10  && daysUntilExpiration > 0){
//     Console.WriteLine("Your subscription expires soon. Renew now!");
//     Console.WriteLine(daysUntilExpiration);

//     if(daysUntilExpiration <= 5 && daysUntilExpiration > 1){
//         discountPercentage = 10;
//         Console.WriteLine($"Renew now and save {discountPercentage}%");
//     }

//     else if(daysUntilExpiration == 1){
//         discountPercentage = 20;
//         Console.WriteLine($"Renew now and save {discountPercentage}%");
//     }
// }

// else if (daysUntilExpiration == 0) {
//     Console.WriteLine("Your subscription has expired");
// }


// string[] fradulentOrderIds = new string[3]; // new array with 3 elements

// fradulentOrderIds[0] = "A123"; //assiging values at the specified index
// fradulentOrderIds[1] = "B456";
// fradulentOrderIds[2] = "C789";
// // fradulentOrderIds[3] = "D000"; example of an out of bounds since index begins at 0

// Console.WriteLine($"First: {fradulentOrderIds[0]}");
// Console.WriteLine($"Second: {fradulentOrderIds[1]}");
// Console.WriteLine($"Third: {fradulentOrderIds[2]}");

// fradulentOrderIds[0] = "F000"; //you can reassign values at an index - as longs as it's the same type

// Console.WriteLine($"Reassign First: {fradulentOrderIds[0]}");

// Console.WriteLine($"There are {fradulentOrderIds.Length}"); // utilizes .Length to get the size or length of the array

// string[] names = {"Rowena", "Robin", "Bao"};

// foreach (string name in names) {
//     Console.WriteLine(name);
// }

// int[] inventory = {200, 450, 700, 175, 250};

// int sum = 0;
// int bin = 0;

// foreach (int items in inventory){
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory");

// string[] fraudId = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// foreach (string item in fraudId){
//     if (item.StartsWith("B")){
//         Console.WriteLine($"{item}");
//     }
// }

// initialize variables - graded assignments 

int currentAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[] emmaScores = new int[] {90, 85, 87, 98, 68};
int[] loganScores = new int[] {90, 95, 87, 88, 96};

int sophiaSum = 0;

decimal sophiaScore;

foreach (int score in sophiaScores){
    sophiaSum += score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

