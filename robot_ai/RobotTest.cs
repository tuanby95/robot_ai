using System.Reflection;

namespace robot_ai
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod]
        public void TestRobotHead()
        {
            var face = new Face();
            
            var leftEye = new Eye();
            var rightEye = new Eye();
            var eyes = new List<Eye>();
            eyes.Add(leftEye);
            eyes.Add(rightEye);
            face.Eyes = eyes;            
            Assert.IsTrue(face.HasEye());

            var hair = new Hair();   

            var ears = new List<Ear>();
            var leftEar = new Ear();
            var rightEar = new Ear();
            ears.Add(leftEar);
            ears.Add(rightEar);

            var neck = new Neck();
            var head = new Head(face, hair, ears, neck);

            var robot = new Robot(head);
            Assert.IsTrue(robot.HasHead());
        }
    }
}