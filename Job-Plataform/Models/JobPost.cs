using System;

namespace Job_Plataform.Models
{
    public class JobPost
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobLocation { get; set; }
        public string Descripton { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactWebSite { get; set; }
        public byte[] CompanyImage { get; set; }

    }
}