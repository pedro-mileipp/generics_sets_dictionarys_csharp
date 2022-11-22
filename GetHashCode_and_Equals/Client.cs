using System;
using System.Collections.Generic;


// Implementação em Classes
namespace GetHashCode_and_Equals
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {   
            if(!(obj is Client)){ // caso de erro
                return false;
            }

            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}