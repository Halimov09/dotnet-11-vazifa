namespace BOX
{
    public class Box
    {
        public Guid BoxId { get; set; }  
        public string BoxName { get; set; }
        public string BoxFirstname { get; set; }  
        public int BoxAge { get; set; }
        public int Boxweigh { get; set; }
        public Box ()
        {
            BoxId = Guid.NewGuid(); 
        }

    }
}