namespace RickAndMortyApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Species { get; set; }
        public string? Gender { get; set; }
        public string? Image { get; set; }
        public Origin? Origin { get; set; } // Nueva propiedad para Origin
        public Location? Location { get; set; } // Nueva propiedad para Location
        public int EpisodeCount { get; set; } // Nueva propiedad para contar episodios
    }

    public class Origin
    {
        public string? Name { get; set; }
        public string? Url { get; set; } // URL para más detalles, si es necesario
    }

    public class Location
    {
        public string? Name { get; set; }
        public string? Url { get; set; } // URL para más detalles, si es necesario
    }
}
