
using System;
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
        var arr = s.Split(' ').Reverse();
        var result = string.Join(' ', arr);
        return result;
    }

    /// <summary>
    /// Create a string from string A by reversing the characters in each word, keeping the word order intact.
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise2(string s)
    {
        var arr = s.Split(' ');
        var result = new StringBuilder(s.Length);
        var last = 1;
        foreach (var b in arr)
        {
            result.Append(string.Join("", b.ToCharArray().Reverse()));

            if (last != arr.Count())
            {
                result.Append(" ");
                last++;
            }
        }

        return result.ToString();
    }

    /// <summary>
    /// Apply text transformations on step 2 and Reverse the casing: uppercase → lowercase, lowercase → uppercase
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise31(string s)
    {
        var array = Exercise2(s).ToCharArray();
        var result = new StringBuilder(s.Length); ;
        foreach (var d in array)
        {
            if (char.IsUpper(d))
            {
                result.Append(char.ToLower(d));
            }
            else if (char.IsLower(d))
            {
                result.Append(char.ToUpper(d));
            }
            else
            {
                result.Append(d);
            }
        }

        return result.ToString();
    }

    /// <summary>
    /// Apply text transformations on step 2 and Capitalize the first letter of each word
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise32(string s)
    {
        var array = Exercise2(s).ToCharArray();
        var result = new StringBuilder(s.Length);
        var count = 1;
        foreach (var d in array)
        {
            if (char.IsWhiteSpace(d) || d == ' ')
            {
                result.Append(d);
                count = 1;
            }
            else if (count != 1)
            {
                result.Append(char.ToLower(d));
                count++;
            }
            else if (count == 1)
            {
                result.Append(char.ToUpper(d));
                count++;
            }
            else
            {
                result.Append(d);
                count++;
            }
        }

        return result.ToString();
    }

    /// <summary>
    /// Apply text transformations on step 2 and Capitalize the first letter of each sentence (Sentences end with ., ?, or !)
    /// </summary>
    /// <param name="s">the input</param>
    /// <returns>the modified string</returns>
    public string Exercise33(string s)
    {
        var array = Exercise2(s).ToCharArray();
        var result = new StringBuilder(s.Length);
        var count = 1;
        foreach (var d in array)
        {
            if (d == '?' || d == '.' || d == '!')
            {
                result.Append(d);
                count = 1;
            }
            else if (count != 1)
            {
                result.Append(char.ToLower(d));
                count++;
            }
            else if (count == 1)
            {
                result.Append(char.ToUpper(d));
                count++;
            }
            else
            {
                result.Append(d);
                count++;

            }
        }

        return result.ToString();
    }


}
