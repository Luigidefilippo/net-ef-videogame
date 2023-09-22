namespace net_ef_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel gestionale gamestop!");

            while (true)
            {
                Console.WriteLine($@"
1: Insert a new video game.
2: Search for a video game by its ID.
3: search for all video games with a name containing a certain input string.
4: Delete a video game.
5: Enter a new Software House.
6: Exit the management system => 
");
                Console.Write("Inserisci l'opzione desiderata --> ");
                int opzioneSelezionata = int.Parse(Console.ReadLine());
                switch (opzioneSelezionata)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
        }
    }
}