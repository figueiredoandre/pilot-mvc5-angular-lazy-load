﻿using Pilot.Entity;
using Pilot.Entity.Domain;
using Pilot.Util.Transaction;
using Pilot.Util.Unity.Lifetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilot.Service.Interfaces
{
    public interface IContactService : ICRUDService<Contact>, IDisposable
    {
        IList<ContactType> GetContactTypes();

        IList<Contact> GetWithMember();
    }
}
