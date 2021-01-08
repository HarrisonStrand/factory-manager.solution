using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntries = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public ICollection<EngineerMachine> JoinEntries { get; }

  }
}