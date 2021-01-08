using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntries = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public ICollection<EngineerMachine> JoinEntries { get; set; }
  }
}