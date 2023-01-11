namespace bbvRobot
{
  public class Eye : BaseCommon
  {
    public Pupil? Pupil { get; set; }
    public Eyeball? Eyeball { get; set; }
    public Eyelid? Eyelid { get; set; }
    public Eye() { }
    public Eye(Pupil pupil, Eyeball eyeball, Eyelid eyelid)
    {
      this.Pupil = pupil;
      this.Eyeball = eyeball;
      this.Eyelid = eyelid;
    }
  }
}