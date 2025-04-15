//Plan is to work on this main gameplay class,and then implement details as they come up
using System.Reflection.Metadata;

Console.WriteLine("Hello, Player!");

//Implement at end
//Console.WriteLine("Would you like to load a save or begin a new game?");

Console.WriteLine("What would you like to be called?");
string playerName = Console.ReadLine();

//Player initializier
Player player= new Player();
    player.Name = playerName;
    player.Health = 100;
    player.Damage = 10;
    player.Location = 13;
    player.AttackState = "block";


Console.WriteLine("Welcome " + player.Name);
Console.WriteLine("you are currently in room " + player.Location);
Console.WriteLine("you have " + player.Health);
 //Character namer and save acknowledgement
 //First room and explantion of systems
 // Core gameplay loop
 //Game win text (maybe leaderboard?)