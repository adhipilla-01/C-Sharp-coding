namespace Constructors
{
    internal class Chess
    {
        string? GameName;
        int NumberOfMoves;
        string? YearOfPlayed;
        string? Player_1Name;
        string? Player_2Name;
        public Chess(string? gameName, int numberOfMoves, string? yearOfPlayed, string? player_1Name, string? player_2Name)
        {
            GameName = gameName;
            NumberOfMoves = numberOfMoves;
            YearOfPlayed = yearOfPlayed;
            Player_1Name = player_1Name;
            Player_2Name = player_2Name;
        }
        public string DisplayInfo()
        {
            return $"\nGame Name : {GameName}\nNumber of Moves : {NumberOfMoves}\nYear of Played : {YearOfPlayed}\nName of the Player-1 : {Player_1Name}\nName of the Player-2 : {Player_2Name}\n";
        }
        public static void Main()
        {
            Console.Write("Enter Game Name : ");
            string? GameName = Console.ReadLine();
            Console.Write("Enter Number of Moves : ");
            int NumberOfMoves = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year of played : ");
            string? YearOfPlayed = Console.ReadLine();
            Console.Write("Enter Player-1 Name : ");
            string? Player_1Name = Console.ReadLine();
            Console.Write("Enter Player-2 Name : ");
            string? Player_2Name = Console.ReadLine();

            Chess Obj = new Chess(GameName, NumberOfMoves, YearOfPlayed, Player_1Name, Player_2Name);
            string MatchInfo = Obj.DisplayInfo();
            Console.WriteLine("\nMatch Details : " + MatchInfo);

            Console.ReadKey();
        }
    }
}
