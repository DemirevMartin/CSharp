using System;
using System.Collections.Generic;
namespace Frenemies
{
class Person
{
     string name; 
     int age; 
     List<Person> friendsList; 
        
     public Person(string nm, int ag)
     {
          if(string.IsNullOrEmpty(nm) || string.IsNullOrWhiteSpace(nm)) throw new ArgumentException("Invalid name: " + nm);
          if(ag < 1) throw new ArgumentException("Invalid age: " + age);
          name = nm;
          age = ag;
           friendsList = new List<Person>();
     }
     public void CreateFriendship(Person other)
     {
         if (this == other) return;
         if(friendsList.IndexOf(other) < 0 ) friendsList.Add(other);
         if (other.friendsList.IndexOf(this) < 0) other.friendsList.Add(this);
     }
     public void DestroyFriendship(Person other)
     {
         if(friendsList.Contains(other)) friendsList.Remove(other);
         if (other.friendsList.Contains(this)) other.friendsList.Remove(this);
     }
     string GetShortInfo()
     {
         return name + ", age: " + age;
     }
     public void PrintInfo()
     {
         Console.WriteLine("{0} has {1} friend/s", GetShortInfo(), friendsList.Count);
         if (friendsList.Count > 0)
         {
             Console.Write("Friends:");
             foreach (Person fr in friendsList)
             {
                 Console.Write(" " + fr.GetShortInfo() + ";");
             }
         Console.WriteLine();
         }
         Console.WriteLine(new String('-', 50));
    }
}
class Program
{
   public static void Main(string[] args)
   {
         Random r = new Random();
         string[] fNames = {"Tony", "Alex", "John", "Peter", "Nora", "Lyra", "Kim"};
         string[] lNames = {"Snow", "Belaqua", "Silver", "Pann", "Roberts", "Braxton", "Bodnia"};

         int n = r.Next(3, 8);
         Person[] prs = new Person[n];
         for (int i = 0; i < n; i++)
         {
            int f = r.Next(fNames.Length);
            int l = r.Next(lNames.Length);
            int age = r.Next(16, 81);
            prs[i] = new Person(fNames[f] + " " + lNames[l], age);
         }

         Console.WriteLine("Initial characters data:");
         foreach (Person p in prs)
         {
             p.PrintInfo();
         }

         n = 15; 
         for (int i = 0; i < n; i++)
         {
             int f = r.Next(prs.Length);
             int l = r.Next(prs.Length);
             prs[f].CreateFriendship(prs[l]);
         }

         Console.WriteLine("After becoming friends:");
         foreach (Person p in prs)
         { 
             p.PrintInfo();
         }

         n = 8; 
         for (int i = 0; i < n; i++)
         {
             int f = r.Next(prs.Length);
             int l = r.Next(prs.Length);
             prs[f].DestroyFriendship(prs[l]);
         }

         Console.WriteLine("After losing friends:");
         foreach (Person p in prs)
         {
             p.PrintInfo();
         }
         Console.ReadKey(true);
      }
   }
}