namespace clinica.Entities
{
    public class Patient
    {
        public string name { get; set; }
        public int id { get; set; }
        public string phone { get; set; }
        public string status { get; set; }
        public int age { get; set; }

        public Patient(string name, int id, string status, int age, string phone)
        {
            this.name = name;
            this.id = id;
            this.status = status;
            this.age = age;
            this.phone = phone;
        }
    }
}
