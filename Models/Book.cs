﻿using System;
using System.Collections.Generic;

namespace Webapplication.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? Title { get; set; }

    public int? AuthorId { get; set; }

    public string? Genre { get; set; }

    public int? PublishYear { get; set; }

    public virtual Author? Author { get; set; }
}
