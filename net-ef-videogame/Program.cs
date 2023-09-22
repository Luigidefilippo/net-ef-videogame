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
                        Console.WriteLine("Enter a name for the new videogames:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the Description for the Videogames");
                        string overview = Console.ReadLine();

                        Console.WriteLine("Enter the realising date ");
                        DateTime realease_date = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the video game software house");
                        long software_house = long.Parse(Console.ReadLine());

                        Videogame newVideogame = new Videogame()
                        {
                            Name = name,
                            Overview = overview,
                            Release_date = realease_date,
                            Software_houseId = software_house
                        };
                        
                        using (VideogameContext db = new VideogameContext())
                        {
                            try
                            {
                                db.Add(newVideogame);
                                db.SaveChanges();

                                Console.WriteLine("The videogame was add  ");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

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