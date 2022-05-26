using Newtonsoft.Json;
using System;

namespace Projeto_Usuários
{
    public class User
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;
        private string _phone;

        public User( string id, string name, string email, string password, string phone)
        {
            _id = id; //Guid.NewGuid().ToString();
            _name = name;
            _email = email;
            _password = password;
            _phone = phone;
        }

        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        
       [JsonProperty(PropertyName = "id")]

       public string Email { get { return _email; } }
       public string Password { get { return _password; } }
       public string Phone { get { return _phone; } }

        
    }
}
