namespace Connect4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LSilvers Connect 4 Game";
            Game game = new Game();
            game.Play();
        }
    }
}