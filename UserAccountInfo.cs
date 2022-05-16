//  ---------------------------------------------------
//
//  Albrecht Ohsiek 578445 26/08/2021
//  Class holding login credentials
//
// ----------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class UserAccountInfo
    {
        // Dictonary used to avoid duplicate usernames
        private Dictionary<string, string> accounts;

        public Dictionary<string, string> Accounts { get => accounts; set => accounts = value; }

        // Default Constructor
        public UserAccountInfo() 
        {
            // temp decionary to assign values
            Dictionary<string, string> temp = new Dictionary<string, string>();

            // Data of usernames and passwords
            temp.Add("Leia", "Leia224");
            temp.Add("Sadie", "Sadie222");
            temp.Add("Jose", "John465");
            temp.Add("Liberty", "Liberty126");
            temp.Add("Bella", "Bella461");
            temp.Add("John", "John664");
            temp.Add("Elmer", "Elmer442");
            temp.Add("Tobais", "Tobais222");
            temp.Add("Steve", "Steve144");
            temp.Add("Samuel", "Samuel361");

            // Administrative account
            temp.Add("admin", "admin0123");

            Accounts = temp;
        }
    }
}
