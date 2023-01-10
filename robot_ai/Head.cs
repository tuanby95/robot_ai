namespace robot_ai
{
    public class Head
    {
        public Face Face;
        public Hair Hair;
        public List<Ear> Ears;
        public Neck Neck;

        public Head(Face face, Hair hair, List<Ear> ears, Neck neck)
        {
            this.Face = face;
            this.Hair = hair;
            this.Ears = ears;
            this.Neck = neck;
        }
    }
}