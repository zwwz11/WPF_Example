using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class User : BaseModel
    {
        private int id;
        private string? name;
        private int age;

        public int ID 
        {
            get { return id; } 
            set 
            {
                id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        public string? Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
    }
}
