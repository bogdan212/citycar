using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notbook.Models
{
    public class Order : BaseEntity
    {
        public Order(){

            statuss = 1;
            sizecar = 1;
            about = "ввод ";

           
           //Contacts = new List<Contact>();
            



        }
        private List<Contact> contacts = new List<Contact>();


        public string Firstname { get; set; }

        public string Secondname { get; set; }

        public DateTime Birthday { get; set; }

        public string City1 { get; set; }

        public string City2 { get; set; }

        public int sizecar { get; set; }

        public int statuss { get; set; }

        public string about { get; set; }

        //public int UserId { get; set; }

        public virtual List<Contact> Contacts { get => contacts; }


    }
}
