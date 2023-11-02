﻿namespace EntityRelations.ApproachesH.Models;

public class Book
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Genre { get; set; } = string.Empty;

    public int Pages { get; set; }
    
    public virtual Author Author { get; set; } = null!;
}