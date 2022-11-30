using System;
using System.Collections.Generic;

namespace ownapi.Models;

public partial class Musicfinder
{
    public int Id { get; set; }

    public string? Artist { get; set; }

    public string? Gender { get; set; }

    public string? Age { get; set; }

    public string? Albums { get; set; }

    public string? Years { get; set; }

    public string? Images { get; set; }

    public string? Lyrics { get; set; }
}
