using System.Collections.Generic;
using System;


namespace Tamagotchi.Models
{
  public class Pet
  {

    public string Name { get; set; }
    public int Food { get; set; } = 100;
    public int Attention { get; set; } = 100;
    public int Sleep { get; set; } = 100;   
    public int Id { get; set;}


    private static List<Pet> _instances = new List<Pet> { };

    public Pet(string name)
    {
      Name = name;
  
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void Play()
    {
      this.Food -= 50;
  
    }
    public void Rest()
    {
      this.Sleep -= 25;
    }

    public void Love()
    {
      this.Attention += 75;
    }

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