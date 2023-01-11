namespace bbvRobot
{
  public class Face
  {
    public List<Eye> eyes { get; set; }
    public Mouth mouth { get; set; }

    public Face()
    {
      var leftEye = new Eye();
      var rightEye = new Eye();

      this.mouth = new Mouth();
      this.mouth.Height = 5;

      this.eyes = new List<Eye>() { leftEye, rightEye };
    }

    internal void OpenEyes()
    {
      setEyeColor("red");
    }

    internal void CloseEyes()
    {
      setEyeColor("black");
    }

    private void setEyeColor(string color)
    {
      foreach (var eye in eyes)
      {
        eye.Color = color;
      }
    }

    internal bool IsEyesOpen()
    {
      foreach (var eye in eyes)
      {
        if (eye.Color == "black")
          return false;
      }
      return true;
    }

    internal void OpenMouth()
    {
      setMouth(50);
    }

    internal void CloseMouth()
    {
      setMouth(5);
    }

    private void setMouth(int Height)
    {
      if (this.mouth is not null)
        this.mouth.Height = Height;
    }

    internal bool IsMouthOpen()
    {
      if (this.mouth is not null && this.mouth.Height == 50)
        return true;
      return false;
    }
  }
}