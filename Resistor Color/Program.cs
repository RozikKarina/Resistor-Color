using System;

public static class ResistorColor
{
    private static readonly string[] colorList =
    {
        "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"
    };

    public static int ColorCode(string color)
    {
        // Знаходимо індекс кольору, який відповідає його числовому значенню
        return Array.IndexOf(colorList, color);
    }

    public static string[] Colors()
    {
        // Повертаємо масив всіх кольорів
        return colorList;
    }
}