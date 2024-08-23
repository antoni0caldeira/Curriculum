namespace CurriculumMVC.Models
{
    public class Certification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Issuer Issuer { get; set; }
        public string Date { get; set; }
        public string ExpirationDate { get; set; }
        public string CredentialID { get; set; }
        public string CredentialURL { get; set; }
        public string CredentialMedia { get; set; }
        public string CredentialDescription { get; set; }

        public Skill[] Skill { get; set; }
    }
}
