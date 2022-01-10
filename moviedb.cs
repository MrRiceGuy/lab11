// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to the MDB!");

bool quit = false;

while (!quit)
{
    Console.WriteLine("There are 10 movies in this list. \n What catagory are you intested in?");

    string inputCategory = Console.ReadLine().ToLower();


    List<Movie> Movies = new List<Movie>()
    {
    };

    Movies.Add(new Movie("Shawshank Redemption", "drama"));
    Movies.Add(new Movie("Interstellar", "scifi"));
    Movies.Add(new Movie("Return of the Jedi", "scifi"));
    Movies.Add(new Movie("Smokin Aces", "drama")); 
    Movies.Add(new Movie("Batman: Under the Red Hood", "animated"));

    Movies.Add(new Movie("School of Rock", "drama"));
    Movies.Add(new Movie("Alien", "horror"));
    Movies.Add(new Movie("True Romance", "drama"));
    Movies.Add(new Movie("Godfather", "drama"));
    Movies.Add(new Movie("Jurassic Park", "drama"));


    foreach (Movie movie in Movies)
    {
      
        if (movie.category == inputCategory)
        {
            Console.WriteLine($"{movie.name}");
        }
      
    }

    Console.WriteLine("Would you like to continue, y/n?");

    if (Console.ReadLine().ToLower() == "n")
    {
        quit = true;
        Console.WriteLine("Goodbye!");
        break;
    }
}


     public class Movie
{

   public string name {get; set; }
   public string category {get; set; }

    public Movie(string name, string category){

        name = name;
        category = category;
    }
}

