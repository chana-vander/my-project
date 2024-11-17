﻿namespace clinica.Entities
{
    public class Prescription
    {
        public int id { get; set; }
        public string description { get; set; }
        public DateOnly startDate { get; set; }
        public DateOnly endDate { get; set; }
        public string status { get; set; }
        public string pName { get; set; } //שם המטופל

        public Prescription(int id, string description, DateOnly startDate, DateOnly endDate, string status, string pName)
        {
            this.id = id;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.pName = pName;
        }

        public Prescription()
        {
            
        }
    }
}
