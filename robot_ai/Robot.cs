namespace robot_ai
{
    public class Robot
    {
        public Head Head { get; set; }
        public Robot(Head head)
        {  
            this.Head = head;
        }
        
        public bool HasHair()
        {
            return true;
        }

        public bool HasHead()
        {
            return true;
        }
    }
}