using System.Collections.Generic;


namespace JobBoard.Models
{
  public class Job
  {
    public string Title { get; set; }
    public string Email { get; set;}
    public int Id { get; }
    private static List<Job> _instances = new List<Job> {};

    public Job(string title, string email)
    {
      Title = title;
      Email = email;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
    _instances.Clear();
    }

    public static Job Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}