﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pilot.Entity
{
    [DataContract]
    public class Member : BaseEntity
    {
        public Member() 
        {
            Contacts = new HashSet<Contact>();
        }

        [DataMember]
        public override long Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        [Editable(false)]
        public virtual ICollection<Contact> Contacts { get; set; }

        [NotMapped]
        public IList<Contact> ContactList
        {
            get { return new List<Contact>(Contacts); }
        }
    }
}
