﻿using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IGroupRepository : IRepository<Group>
    {
        List<Group> GetGroupsByOrganizerId(int organizerId);
    }
}
