using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Videos{
    public string _title;
    public string _author;
    public int _videoDuration;
    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        //Add the comment list
        _comments.Add(comment);
    }

    public int CountComments()
    {
        //Count comments in the list using the .count property
        return _comments.Count ;
    }

    public void DisplayVideoInfo()
    {
        //How it will look like
        Console.WriteLine($"Title: {_title}:");
        Console.WriteLine($"Author: {_author}:");
        Console.WriteLine($"Duration: {_videoDuration}s - ");
        Console.WriteLine($"Number of comments - ({CountComments()})");

        foreach (Comment comments in _comments)
        {
            comments.DisplayComment();
        }
    }
}