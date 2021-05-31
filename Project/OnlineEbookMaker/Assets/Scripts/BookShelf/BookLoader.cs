using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class BookLoader
{
    private const string bookListkey = "booklist";

    public static string[] LoadBookIdList()
    {
        string value = PlayerPrefs.GetString(bookListkey);
        return value.Split('/');
    }

    public static void SaveBookIdList(List<string> bookIdList)
    {
        StringBuilder builder = new StringBuilder();
        foreach (var id in bookIdList)
        {
            builder.Append(id);
            builder.Append('/');
        }
        PlayerPrefs.SetString(bookListkey,builder.ToString());
        PlayerPrefs.Save();
    }
}