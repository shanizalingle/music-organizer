using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string RecordTitle { get; set; }
    public int Id { get; }

    private static List<Record> _records = new List<Record> {};

    public Record(string recordTitle)
    {
      RecordTitle = recordTitle;
      Id = _records.Count;
      _records.Add(this);
    }
    public static List<Record> GetAll()
    {
      return _records;
    }
    public static void ClearAll()
    {
      _records.Clear();
    }
    public static Record Find(int searchId)
    {
      return _records[searchId-1];
    }
  }
}