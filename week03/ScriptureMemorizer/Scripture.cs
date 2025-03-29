using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        //When it comes to the words, we're gonna need to split up the words in the text and store as a word object in the list _words
        _reference = Reference;
        //string name = "Yolanda Nzimande";
        //string[]words = name.Split(" ");
        //You're going to want to split and then loop through each word
        //Create a word object with each word, and put it into _words.
        string[] splitText = text.Split(" "); 
        foreach (string wordText in splitText)
        {
           Word word = new Word(wordText);
           _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Has the ability to hide random words and how many you want to hide.
        //Goal : Set the state of a randomly selected group of words to be hidden

        //Step 1: Need to find a set of visible words(remember to call on other function that can tell you if something is hidden or not)
        //Step 2: Randomly select 'numberToHide' of those words, there are many ways to do this, you can use if statements, loops
        //Make sure you call IsVisible function
        //How to hide words? 
        //Use hide function, when doing this things will get set when someone calls GetDisplayText
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if(word.IsHidden() == false)
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count == 0)
        return;  

        numberToHide = Math.Min(numberToHide, visibleWords.Count);
        Random random = new Random();
        for(int i=0; i< numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        // This is going to display everything, the reference infomation and display the words with some of them hidden.
        //We should not worry whether the word is hidden or not
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        // Combine with the reference (e.g., "John 3:16 ___ ____ ___")
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        //Public function that can be called to determine if we are done with the program.
        foreach(Word word in _words)
        {
            if(word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}