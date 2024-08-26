using IMDB_List;

//liste Movie classı ile tanımlandı.
List<Movie> movies = new List<Movie>();

//degişkenler tanımlandı
double imdbPoint;
string movieName;
bool puangiris;

//Film ekleme menüsü yapıldı.
while (true)
{
    Console.Write("Lütfen film adını giriniz: ");
    movieName = Console.ReadLine();

    //imdb puan kontrolü
    while (true)
    {
        Console.Write("Lütfen İmdb puanını giriniz: ");
        puangiris = double.TryParse(Console.ReadLine(), out imdbPoint);

        if (puangiris && imdbPoint > 0 && imdbPoint <= 10)
            break;
    }
    //Burada Movie classı ile yeni bir nesne türetiyoruz.
    Movie newMovie = new Movie(movieName, imdbPoint);
    movies.Add(newMovie);

    //burada yeni film eklemek isteyip istemediğini soruyoruz.
    control:  Console.WriteLine("Yeni bir film eklemek istiyor musunuz (evet / hayır):");
    string choice = Console.ReadLine();
    if (choice == "hayır")
    {
        //bütün filmlerin listesi
        Console.WriteLine("----------- Bütün Filmler ----------");
        foreach (Movie movie in movies)
        {
            Console.WriteLine($"Film Adı: {movie.Name} - İMDB Puanı: {movie.ImdbPoint}");
        }

        // imdb puanı 4 ile 9 arası
        Console.WriteLine("----------- İmdb 4 ile 9 arası ----------");
        foreach (Movie movie in movies)
        {
            if (movie.ImdbPoint > 4 && movie.ImdbPoint < 10)
            {
                Console.WriteLine($"Film Adı: {movie.Name} - İMDB Puanı: {movie.ImdbPoint}");
            }
        }


        //İsmi a ile başlayan filmler
        Console.WriteLine("----------- İsmi A ile başlayan filmler----------");
        foreach (Movie movie in movies)
        {
            if (movie.Name.StartsWith("A") || movie.Name.StartsWith("a"))
            {
                Console.WriteLine($"Film Adı: {movie.Name} - İMDB Puanı: {movie.ImdbPoint}");
            }
        }

        break;
    }
    else if (choice == "evet")
        continue;
    else
        goto control;
}