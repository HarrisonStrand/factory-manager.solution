namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public Engineer Engineer { get; set; }
    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public Machine Machine { get; set; }
  }
}