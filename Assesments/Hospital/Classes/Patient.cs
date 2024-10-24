namespace Hospital.Classes
{
    public class Patient
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; } 
        public string MedicalCondition { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}