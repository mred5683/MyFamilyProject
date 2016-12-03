using System;

namespace MyFamilyProject {
  internal class Program {
    private static void Main(string[] args) {
      var bob = new Husband("Robert David Hansen", "33", "Lab Technician",
        "Become someone the whole family can be proud of!!");
      var kymber = new Wife("Kymber Lee Hansen", "26", "Business Stuff", "To be the best wife and mommy in the world!!");
      var tayber = new Offspring("Tayber Wendell Belt", "9", "LEGOS!!", "Batman!!", "Dishes, Trash, Clean Bedroom");
      var riley = new Offspring("Riley Hansen", "1", "Back Scratcher", "undecided",
        "Eating, Crying, Playing, Sleeping, Throw Diapers Away");
      var kendra = new Offspring("Kendra Lee Elizebeth Hansen", "unbord child", "Jumping on Mommies Bladder!!!",
        "undecided", "Growing into a beautiful baby girl!!");

      {
        Console.WriteLine("Which family member would you like to learn about?\n");
        Console.WriteLine("  Bob\n  Kymber\n  Tayber\n  Riley\n  Kendra\n\n");

        var personOfChoice = Console.ReadLine();

        Console.WriteLine("What info would you like to request?\n");

        var personOfChoiceInfo = Console.ReadLine();

        switch (personOfChoice) {
          case "Bob":
            if ((personOfChoice == "Bob") && (personOfChoiceInfo == "All Information"))
              Console.WriteLine("\nFull Name: " + bob.Name + "\nAge: " + bob.Age + "\nJob Title: "
                                + bob.Job + "\nGoal: " + bob.Goal + bob.Job +
                                ",And a goal he has set for himself is to become someone the whole family can be proud of.");

            if ((personOfChoice == "Bob") && (personOfChoiceInfo == "Full Name"))
              Console.WriteLine(bob.Name);
            if ((personOfChoice == "Bob") && (personOfChoiceInfo == "Age"))
              Console.WriteLine(bob.Age);
            if ((personOfChoice == "Bob") && (personOfChoiceInfo == "Job"))
              Console.WriteLine(bob.Job);
            if ((personOfChoice == "Bob") && (personOfChoiceInfo == "Goal"))
              Console.WriteLine(bob.Goal);
            break;

          case "Kymber":
            if ((personOfChoice == "Kymber") && (personOfChoiceInfo == "All Information"))
              Console.WriteLine("\nFull Name: " + kymber.Name + "\nAge: " + kymber.Age + "\nJob Title: " +
                                kymber.Job + "\nGoal: " + kymber.Goal);
            if ((personOfChoice == "Kymber") && (personOfChoiceInfo == "Full Name"))
              Console.WriteLine(kymber.Name);
            if ((personOfChoice == "Kymber") && (personOfChoiceInfo == "Age"))
              Console.WriteLine(kymber.Age);
            if ((personOfChoice == "Kymber") && (personOfChoiceInfo == "Job"))
              Console.WriteLine(kymber.Job);
            if ((personOfChoice == "kymber") && (personOfChoiceInfo == "Goal"))
              Console.WriteLine(kymber.Goal);
            break;

          case "Kendra":
            if ((personOfChoice == "Kendra") && (personOfChoiceInfo == "All Information"))
              Console.WriteLine("\nFull Name: " + kendra.Name + "\nAge: " + kendra.Age + "\nJob Title: " +
                                kendra.FavoriteToy + "\nFavorite SuperHero: " + kendra.FavoriteSuperHero + "\nChores: " +
                                kendra.Chores);
            if ((personOfChoice == "Kymber") && (personOfChoiceInfo == "Full Name"))
              Console.WriteLine(kymber.Name);
            if ((personOfChoice == "Kymber") && (personOfChoiceInfo == "Age"))
              Console.WriteLine(kymber.Age);
            if ((personOfChoice == "Kymber") && (personOfChoiceInfo == "Job"))
              Console.WriteLine(kymber.Job);
            if ((personOfChoice == "kymber") && (personOfChoiceInfo == "Goal"))
              Console.WriteLine(kymber.Goal);
            break;
        }
      }
    }
  }
}
