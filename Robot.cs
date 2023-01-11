namespace bbvRobot
{
  internal class Robot
  {
    public Head Head { get; private set; }
    public Body Body { get; private set; }
    public List<Hand> Hands { get; private set; }
    public List<Leg> Legs { get; private set; }

    public Robot()
    {
      var leftHand = new Hand();
      var rightHand = new Hand();
      var leftLeg = new Leg();
      var rightLeg = new Leg();

      this.Head = new Head();
      this.Body = new Body();
      this.Hands = new List<Hand>() { leftHand, rightHand };
      this.Legs = new List<Leg>() { leftLeg, rightLeg };
    }
    internal bool HasHead()
    {
      return this.Head != null;

    }
    internal bool HasBody()
    {
      return this.Body != null;

    }
    internal bool HasLegs()
    {
      return this.Legs != null;

    }
    internal bool HasHands()
    {
      return this.Hands != null;

    }

    internal void Kick(string side)
    {
      foreach (var leg in Legs)
      {
        if (leg.Side == side)
        {
          // doSomeThing;
          break;
        }
      }
    }
  }
}