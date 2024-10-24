namespace Hospital.Classes
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Specialisation Specialisation { get; set; }
        public int PatientID { get; set; }
    }

    public enum Specialisation
    {
        Cardiology,
        Neurology,
        Orthopedic,
        Gastrology
    }
}