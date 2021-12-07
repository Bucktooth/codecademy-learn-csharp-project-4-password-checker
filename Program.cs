using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = " ";
      string lowercase = " ";
      string digits = " ";
      string specialChars = " ";

      Console.WriteLine("Enter a password:");
      string password = Console.ReadLine();

      int score = 0;

      if (password.Length >= minLength)
      {
        score += 1;
      }
      if (Tools.Contains(password, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
      {
        score += 1;
      }
      if (Tools.Contains(password, "abcdefghijklmnopqrstuvwxyz"))
      {
        score += 1;
      }
      if (Tools.Contains(password, "1234567890"))
      {
        score += 1;
      }
      if (Tools.Contains(password, "~!@#$%^&*()-"))
      {
        score += 1;
      }
      if (password == "1234")
      {
        score = 0;
      }
      if (password == "password")
      {
        score = 0;
      }

      Console.WriteLine(score);

      switch (score)
      {
        case 4:
        case 5:
          Console.WriteLine("The password is extremely strong.");
          break;
        case 3:
          Console.WriteLine("The password is strong.");
          break;
        case 2:
          Console.WriteLine("The password is medium.");
          break;
        case 1:
          Console.WriteLine("The password is weak.");
          break;
        default:
          Console.WriteLine("The password doesn't meet any of the standards.");
          break;
      }
    }
  }
}
