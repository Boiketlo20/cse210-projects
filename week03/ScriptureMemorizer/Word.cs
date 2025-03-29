using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public void Hide()
    {
        //It's purpose is to indicate that this word should be hidden
        //The goal is to change the state, so that when someone calls GetDisplayText, the right thing gets returned.
        _isHidden = true;

    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        // Should return a word if visible or return underscores if hidden.
        // try using an if statement
        if (_isHidden == true)
        {
            return new string ('_',_text.Length);
        }
        else
        {
            return $"{_text}";
        }
    }
}