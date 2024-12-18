// See https://aka.ms/new-console-template for more information
using Linq_Learning;

var games = new List<Game>
{
    new Game
    {
        Title = "The Shawshank Redemption",
        Genre = "Drama",
        ReleaseYear = 1994,
        Rating = 9.2,
        Price = 12
    },
    new Game
    {
        Title = "The Dark Knight",
        Genre = "Action",
        ReleaseYear = 2008,
        Rating = 9.0,
        Price = 15
    },
    new Game
    {
        Title = "The Lord of the Rings: The Return of the King",
        Genre = "Fantasy",
        ReleaseYear = 2003,
        Rating = 9.2,
        Price = 14
    },
    new Game
    {
        Title = "The Lord of the Md Op",
        Genre = "Fantasy",
        ReleaseYear = 2005,
        Rating = 9.5,
        Price = 15
    }
};

//Linq Select its select all the data

//var AllGames = games.Select(x => x.Title);    

//foreach (var Title in AllGames)
//{
//    Console.WriteLine(Title);
//}

//Linq Where its find the Data

//var FanGenre = games.Where(x => x.Genre == "Fantasy");
//foreach (var genre in FanGenre)
//{
//    Console.WriteLine(genre.Title);
//}

//Linq Any its find the Data ( It provide true or false )

//var modernGenreExist = games.Any(game => game.ReleaseYear > 2000);
//Console.WriteLine(modernGenreExist);

// linq order by help us in provide in the order Ascending  and OrderByDescending help up provide in order desc 

//var sortByYear = games.OrderBy(x => x.ReleaseYear);
//foreach (var game in sortByYear)
//{
//    Console.WriteLine($"{game.Title},{ game.ReleaseYear}");
//}


//linq Average help us provide average of the number 

//var averagePrice = games.Average(x => x.Price);
//Console.WriteLine(averagePrice);


// Linq max provide the max value 

//var highestRating = games.Max(game => game.Rating);
//Console.WriteLine(highestRating);


// Linq min provide the min value 

//var lowestRating = games.Min(game => game.Rating);
//Console.WriteLine(lowestRating);

// linq GroupBy help us provide data in group

//var groupByGenre = games.GroupBy(x => x.Genre);
//foreach (var game in groupByGenre)
//{
//    Console.WriteLine($"Genre :  {game.Key}");
//    foreach ( var title in game)
//    {
//        Console.WriteLine(title.Title);
//    }
//}

//var budgetAdventureGames = games
//    .Where(g => g.Genre == "Fantasy" && g.Price <= 15)
//    .OrderByDescending(g => g.Rating)
//    .Select(g => $"{g.Title} - {g.Price} - {g.Rating}");

//foreach( var game in budgetAdventureGames )
//{
//    Console.WriteLine(game);
//}

// linq skip and take which help in paginator 

//var pagination = games.Skip(1).Take(3);
//foreach (var game in pagination)
//{
//    Console.WriteLine(game.Title);
//}

//Linq Distinct we wont getn any duplicate 
//var DistinctGame = games.Select(g => g.Genre).Distinct();
//foreach(var game in DistinctGame)
//{
//    Console.WriteLine(game);
//}