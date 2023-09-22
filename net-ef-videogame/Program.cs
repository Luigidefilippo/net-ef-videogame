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
                        Console.WriteLine("Enter the id of the video game to search for");
                        long gameid = long.Parse(Console.ReadLine());

                        using (VideogameContext db = new VideogameContext())
                        {
                            Videogame videogame = db.Videogames.FirstOrDefault(videogame => videogame.VideogameId == gameid); 
                            if (videogame != null)
                            {
                                Console.WriteLine($"Name : {videogame.Name}");
                                Console.WriteLine($"Overview: {videogame.Overview}");
                                Console.WriteLine($"Realise : {videogame.Release_date}");
                                Console.WriteLine($"Id Softweare house : {videogame.Software_houseId}");
                            }
                            else
                            {
                                Console.WriteLine("No Reasult for this search ");
                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("Sarch for string ");
                        string stringa = Console.ReadLine();
                        using (VideogameContext db = new VideogameContext())
                        {
                            List<Videogame> videogame = db.Videogames.Where(videogame => videogame.Name.StartsWith(stringa)).ToList<Videogame>();
                            foreach ( Videogame videogameFound in videogame )
                            {
                                Console.WriteLine($"{videogameFound.Name}");
                            }
                        }
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