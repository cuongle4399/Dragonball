using System;
using System.IO;

class Program
{
    public static void Base64toImage(string s, string filePath)
    {
        byte[] imageBytes = Convert.FromBase64String(s);
        File.WriteAllBytes(filePath, imageBytes);
        Console.WriteLine("Đã convert base64 to image: Thành Công");
    }
    public static void ImageToBase64(string filePath)
    {
        byte[] imageBytes = File.ReadAllBytes(filePath);
        
        string s = Convert.ToBase64String(imageBytes);
        File.WriteAllText("output.txt", s);
        Console.WriteLine("Đã convert image to base64: Thành Công");
    }
    static void Main()
    {
        ImageToBase64("logo9.png");
    }
}
