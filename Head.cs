namespace bbvRobot
{
  internal class Head
  {
    public Face Face { get; set; }

    public Hair Hair { get; set; }

    public List<Ear> Ears { get; set; }

    public Head()
    {
      var leftEar = new Ear();
      var rightEar = new Ear();

      this.Ears = new List<Ear>() { leftEar, rightEar };
      this.Face = new Face();
      this.Hair = new Hair();
    }

    internal bool HasHair()
    {
      return Hair != null;
    }

    internal bool HasFace()
    {
      return Face != null;
    }

    internal void LightUpEar(string side)
    {
      setEarColor(side, "red");
    }
    internal void LightDownEar(string side)
    {
      setEarColor(side, "black");
    }

    private void setEarColor(string side, string color)
    {
      foreach (var ear in Ears)
      {
        if (ear.Side == side || side == "both")
        {
          ear.Color = color;
        }
      }
    }

    internal bool isEarsLightUp()
    {
      foreach (var ear in Ears)
      {
        if (ear.Color != "red")
          return false;
      }
      return true;
    }
  }
}