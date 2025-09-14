using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }

    public SelectList? Years { get; set; }  // Shows list of years in drop-down
    public int? SearchYear { get; set; }  // Holds the selected year from drop-down
}