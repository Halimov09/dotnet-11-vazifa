namespace STUDENTS
{
    public class Student 
    {
        public Guid Id { get; set; }  
        public string Name { get; set; }
        public string FirstName { get; set; }  
        public int Room { get; set; }
        public int Grade { get; set; }

        public Student ()
        {
            Id = Guid.NewGuid(); 
        }
    }
}