using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _artists = new List<Artist> {};

    public string ArtistName { get; set; }
    public int Id { get; }
    public List<Record> Records { get; set; }
    public Artist(string artistName )
    {
      ArtistName = artistName;
      _artists.Add(this);
      Id = _artists.Count;
      Records = new List<Record>{};
    }
    public static void ClearAll()
    {
      _artists.Clear();
    }
    public static List<Artist> GetAll()
    {
      return _artists;
    }
    public static Artist Find(int searchId)
    {
      return _artists[searchId-1];
    }
    public void AddRecord(Record record)
    {
      Record.Add(record);
    }
  }
}