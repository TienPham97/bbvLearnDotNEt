namespace bbvRobot
{
  internal class Body
  {
    private Chest? chest { get; set; }
    private Shoulder? shoulder { get; set; }
    private Belly? belly { get; set; }

    public Body()
    {
      this.chest = new Chest();
      this.shoulder = new Shoulder();
      this.belly = new Belly();
    }
  }
}