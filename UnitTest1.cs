namespace bbvRobot;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void RobotAttributeTest()
  {
    var robot = new Robot();

    Assert.IsTrue(robot.HasHead());
    Assert.IsTrue(robot.HasBody());
    Assert.IsTrue(robot.HasHands());
    Assert.IsTrue(robot.HasLegs());
  }
  [TestMethod]
  public void HeadAttributeTest()
  {
    var head = new Head();

    Assert.IsTrue(head.Ears?.Count == 2);
    Assert.IsTrue(head.HasHair());
    Assert.IsTrue(head.HasFace());
  }
  //Behavior
  [TestMethod]
  public void OpenEyesTest()
  {
    var face = new Face();

    face.OpenEyes();
    Assert.AreEqual(face.IsEyesOpen(), true);

    face.CloseEyes();
    Assert.AreEqual(face.IsEyesOpen(), false);

  }
  [TestMethod]
  public void LightUpEarsTest()
  {
    var head = new Head();

    head.LightUpEar("left");
    Assert.AreEqual(head.isEarsLightUp(), false);

    head.LightUpEar("both");
    Assert.AreEqual(head.isEarsLightUp(), true);

    head.LightDownEar("right");
    Assert.AreEqual(head.isEarsLightUp(), false);
  }
  [TestMethod]
  public void OpenMouthTest()
  {
    var face = new Face();

    face.OpenMouth();
    Assert.AreEqual(face.IsMouthOpen(), true);

    face.CloseMouth();
    Assert.AreEqual(face.IsMouthOpen(), false);
  }
  [TestMethod]
  public void LegKickTest()
  {
    var robot = new Robot();

    robot.Kick("left");
  }
}