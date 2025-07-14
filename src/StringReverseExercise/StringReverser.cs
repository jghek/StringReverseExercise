
using System;
using System.Linq;
using System.Text;
namespace StringReverseExercise;

public class StringReverser
{
    /// <summary>
    /// From string A, create string B by reversing the order of words. Punctuation should stay attached to the word.
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise1(string s)
    {
        var result = string.Join(' ', s.Split(' ').Reverse());
        return result;
    }

    /// <summary>
    /// Create a string from string A by reversing the characters in each word, keeping the word order intact.
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise2(string s)
    {
        var result = string.Join(' ', s.Split(' ').Select(s =>
        new String(s.ToCharArray().Reverse().ToArray())
        ));

        return result;
    }

    /// <summary>
    /// Apply text transformations on step 2 and Reverse the casing: uppercase → lowercase, lowercase → uppercase
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise31(string s)
    {
        var result = string.Join(' ', Exercise2(s).Split(' ').Select(s => new String(s.ToCharArray().Select(s2 =>
        char.IsUpper(s2) ? char.ToLower(s2) : char.IsLower(s2) ? char.ToUpper(s2) : s2).ToArray())));

        return result.ToString();
    }

    /// <summary>
    /// Apply text transformations on step 2 and Capitalize the first letter of each word
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise32(string s)
    {
        var result = string.Join(' ', Exercise2(s).Split(' ').Select(s => s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length-1).ToLower()));

        return result.ToString();
    }

    /// <summary>
    /// Apply text transformations on step 2 and Capitalize the first letter of each sentence (Sentences end with ., ?, or !)
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise33(string s)
    {
        var result = string.Join(' ', Exercise2(s).Split(' ').Select(s =>
        //s == "." ? s : s
        //new String(s.ToCharArray().Select( s =>  ))
        s.Substring(0, 1) == "." ? s.Substring(0, 1) + s.Substring(1, 1).ToUpper() + s.Substring(2, s.Length - 2).ToLower() : 
        s.Substring(0, 1) == "?" ? s.Substring(0, 1) + s.Substring(1, 1).ToUpper() + s.Substring(2, s.Length - 2).ToLower() :
        s.Substring(0, 1) == "!" ? s.Substring(0, 1) + s.Substring(1, 1).ToUpper() + s.Substring(2, s.Length - 2).ToLower() : s.ToLower()





        ));

        //var array = Exercise2(s).ToCharArray();
        //var result = new StringBuilder(s.Length);
        //var count = 1;
        //foreach (var d in array)
        //{
        //    if (d == '?' || d == '.' || d == '!')
        //    {
        //        result.Append(d);
        //        count = 1;
        //    }
        //    else if (count != 1)
        //    {
        //        result.Append(char.ToLower(d));
        //        count++;
        //    }
        //    else if (count == 1)
        //    {
        //        result.Append(char.ToUpper(d));
        //        count++;
        //    }
        //    else
        //    {
        //        result.Append(d);
        //        count++;

        //    }
        //}

        return result.ToString();
    }


}
