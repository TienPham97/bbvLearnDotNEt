namespace bbvRobot
{
  public class Leg
  {
    public Foot? Foot { get; set; }
    public Ankle? Ankle { get; set; }
    public Knee? Knee { get; set; }
    public Thighs? Thighs {get; set;}
    public string? Side {get; set;}

    public Leg() {
      this.Foot = new Foot();
      this.Ankle = new Ankle();
      this.Knee = new Knee();
      this.Thighs = new Thighs();
      this.Side = "";
    }
  }
}