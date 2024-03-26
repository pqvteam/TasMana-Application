﻿using Repositories;
using Repositories.Entities;
using Repositories.Utilities;
using System.Collections.Generic;

namespace Services
{
    public class GiaoViecService
    {
        GiaoViecRepository repository = new GiaoViecRepository();

        public GiaoViec? findAssignedTask(string assignedTaskID)
        {   
            GiaoViec? assignedTask = repository.Get(assignedTaskID);
            if (assignedTask == null) return null;
            return assignedTask;
        }

        public bool assignTask(string description, string day, string deadline, string status, string file, string id, int mode, string name, string vanue, string receiverID, int isCEO, string CEOID)
        {
            return repository.Create(description, day, deadline, status, file, id, mode, name, vanue, receiverID, isCEO, CEOID);
        }

        public string getAssignTaskID(string assignerID)
        {
            return GiaoViecUtilities.createAssignTaskID(assignerID);
        }
    }
}