using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AzureBasics
{
    class Child
    {
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int Grade { get; set; }
        public Pet[] Pets { get; set; }
    }
}
