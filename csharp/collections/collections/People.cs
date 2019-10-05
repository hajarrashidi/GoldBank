using System;
namespace collections
{
    public class People
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string gender { get; set; }
        public string IPAdress { get; set; }

        public People(int id, string firstName, string lastname, string email, string gender, string ipAdress)
        {
            Id = id;
            FirstName = firstName;
            Lastname = lastname;
            Email = email;
            this.gender = gender;
            IPAdress = ipAdress;
        }
    }
}
