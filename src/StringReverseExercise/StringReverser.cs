using static System.Net.Mime.MediaTypeNames;

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
        var arr = s.Split(' ');
        var b = arr.Reverse();
        var result = string.Join(' ', b);
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
        var words = arr.Count() - 1;
        var result = "";
        foreach (var b in arr)
        {
            var letters = b.ToCharArray().Reverse();
            foreach (var c in letters)
            {
                result += c;
            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }

        return result;
    }

	/// <summary>
	/// Apply text transformations on step 2 and Reverse the casing: uppercase → lowercase, lowercase → uppercase
	/// </summary>
	/// <param name="s">the input</param>
	/// <returns>the modified string</returns>
	public string Exercise31(string s)
	{
        var arr = s.Split(" ");
        var words = arr.Count() - 1;
        var result = "";
        foreach (var b in arr)
        {
            var letters = b.ToCharArray().Reverse();
            foreach (var c in letters)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else
                {
                    result += c;
                }

            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }
        return result;
    }

	/// <summary>
	/// Apply text transformations on step 2 and Capitalize the first letter of each word
	/// </summary>
	/// <param name="s">the input</param>
	/// <returns>the modified string</returns>
	public string Exercise32(string s)
	{
        var arr = s.Split(" ");
        var words = arr.Count() - 1;
        var result = "";
        foreach (var b in arr)
        {
            var letters = b.ToCharArray().Reverse();
            var count = 1;
            foreach (var c in letters)
            {
                if (count == 1 && char.IsLower(c))
                {
                    result += char.ToUpper(c);
                    count++;
                }
                else if (count != 1)
                {
                    result += char.ToLower(c);
                    count++;
                }
                else
                {
                    result += c;
                    count++;

                }
            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }
        return result;
    }

	/// <summary>
	/// Apply text transformations on step 2 and Capitalize the first letter of each sentence (Sentences end with ., ?, or !)
	/// </summary>
	/// <param name="s">the input</param>
	/// <returns>the modified string</returns>
	public string Exercise33(string s)
	{
        var arr = s.Split(" ");
        var result = "";
        var words = arr.Count() - 1;
        var count = 1;
        foreach (var b in arr)
        {
            var letters = b.ToCharArray().Reverse();

            foreach (var c in letters)
            {
                if (c == '.' || c == '!' || c == '?')
                {
                    count = 1;
                    result += c;
                }
                else if (count == 1)
                {
                    result += char.ToUpper(c);
                    count++;
                }
                else if (count != 1)
                {
                    result += char.ToLower(c);

                }
                else
                {
                    result += c;
                }
            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }
        return result;
    }


}
