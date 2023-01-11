namespace bbvRobot
{
  public class Mouth : BaseCommon
  {
    public Lip? Lip { get; set; }

    public Mouth()
    {
      this.Lip = new Lip();
    }
  }
}