namespace bbvRobot
{
  public class Hand : BaseCommon
  {
    private Arm? arm { get; set; }
    private Wrist? wrist { get; set; }
    private Elbow? elbow { get; set; }
    public string? Side { get; set; }

    public Hand()
    {
      this.arm = new Arm();
      this.wrist = new Wrist();
      this.elbow = new Elbow();
      this.Side = "";
    }
  }
}