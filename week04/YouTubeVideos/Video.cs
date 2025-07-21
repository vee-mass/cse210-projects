using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Transactions;
public class Video
{
    private string author;
    private string title;
    private int lengthInSecs;
    private List<Comment> comments;

    public Video(string author, string title, int lengthInSecs)
    {
        this.author = author;
        this.title = title;
        this.lengthInSecs = lengthInSecs;
        comments = new List<Comment>();
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int LengthInSecs
    {
        get { return lengthInSecs; }
        set { lengthInSecs = value; }
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

}