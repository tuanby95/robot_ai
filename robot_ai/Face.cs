namespace robot_ai
{
    public class Face
    {
        public Face()
        {
            
        }
        public List<Eye> Eyes { get; set; }
        public Mouth Mouth { get; set; }
        public List<Nose> Nose { get; set; }

        public bool HasEye()
        {
            return (Eyes.Count > 1);
        }
    }
}