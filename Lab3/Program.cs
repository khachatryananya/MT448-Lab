using System;

enum Genre
{
    Action = 1,
    Comedy,
    Thriller,
    Fantasy,
    Horror
}

class Movie
{
    public int Number { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public Genre MovieGenre { get; set; }
    public int Views { get; set; }
    public int Likes { get; set; }

    public Movie(int number, string title, int year, Genre genre, int views, int likes)
    {
        Number = number;
        Title = title;
        Year = year;
        MovieGenre = genre;
        Views = views;
        Likes = likes;
    }

    public double CalculateRating()
    {
        if (Views == 0) return 0;
        return Math.Sqrt((double)(Likes * Likes) / Views);
    }

    public override string ToString()
    {
        string genreStr = MovieGenre.ToString();
        string yearStr = $"({Year})";
        double rating = CalculateRating();

        return $"{Number,4} | {Title,-15} | {yearStr,-8} | {genreStr,-12} | {rating,8:F3}";
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Enter the number of movies: ");
        int count = int.Parse(Console.ReadLine());

        Movie[] movies = new Movie[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nEnter movie #{i + 1} data:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int number = int.Parse(parts[0]);
            string title = parts[1];
            int year = int.Parse(parts[2]);
            Genre genre = (Genre)int.Parse(parts[3]);
            int views = int.Parse(parts[4]);
            int likes = int.Parse(parts[5]);

            movies[i] = new Movie(number, title, year, genre, views, likes);
        }

        Console.WriteLine("\n--- Movies List ---");
        foreach (var movie in movies)
        {
            Console.WriteLine(movie.ToString());
        }
    }
}