using System.Collections.Generic;
using System;


namespace Tamagotchi.Models
{
  public class Pet
  {

    public int MaxFood = 100;
    public int MaxAttention = 100;
    public int MaxRest = 100;
    public int GiveFood = 10;
    public int GiveAttention = 10;
    public int GiveRest = 10;
    public string Name { get; set; }
    public int Id { get; }

    public string name;

    public int food;
    public int attention;
    public int rest;
    private static List<Pet> _instances = new List<Pet> { };

    public Pet(string name, int food, int attention, int rest)
    {
      
      // name = this.GetName();
      food = MaxFood;
      attention = MaxAttention;
      rest = MaxRest;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public int Play()
    // {

    // }

    public static List<Pet> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Pet Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}