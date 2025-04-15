public class Gameplay{



    //Plan is to work on this main gameplay class,and then implement details as they come up

    public void start(){
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
    }

    //method to be called for when player moves between rooms
    public void MovePlayer(Player player) {
    Boolean moved = false;

    //Loop that repeats until an acceptable direction is confirmed
    while (!moved) {
        //Player input is stored as a lowercase word so capitalization isnt a problem
        Console.WriteLine("Which direction do you want to move? (north/south/east/west)");
        string direction = Console.ReadLine().ToLower();

        //New location is stored seperatly from players current location until direction is confirmed as possible
        int newLocation = player.Location;

        //Using if else/else if for each direction was working but was real hard to follow, switch cases are way easier to follow/change
        switch (direction) {
        //The map is visualized on a 5 by 5 grid,Going north boosts you up a row while going east moves you along a column (and vice versa for south/west)
        case "north":
                newLocation += 5;
                    break;
                case "south":
                    newLocation -= 5;
                    break;
                case "east":
                    newLocation += 1;
                    break;
                case "west":
                    newLocation -= 1;
                    break;
                    //User loops if any other direction is chosen
                default:
                    Console.WriteLine("Invalid direction. Try 'north', 'south', 'east', or 'west'.");
                    continue;
            }

            //Resets user if they go beyond the 5x5 grid
            if (newLocation < 1 || newLocation > 25) {
                Console.WriteLine("You can't move that way. There's a wall. Try again.");
            } else {
                //confrims location and switches boolean to true to end loop
                player.Location = newLocation;
                Console.WriteLine("You moved "+ direction +".");
                moved = true;
            }
        }
    }
}

//Character namer and save acknowledgement
//First room and explantion of systems
// Core gameplay loop
//Game win text (maybe leaderboard?)
//game lose scenario