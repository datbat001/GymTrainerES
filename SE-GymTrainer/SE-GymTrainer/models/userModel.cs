using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_GymTrainer.models
{
    internal class userModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        
        
        public userModel(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public userModel(string name, string password, string email, string peso, string altura)
        {
            Name = name;
            Password = password;
            Email = email;
            this.peso = peso;
            this.altura = altura;
        }

        public userModel()
        {
        }
    }
}
