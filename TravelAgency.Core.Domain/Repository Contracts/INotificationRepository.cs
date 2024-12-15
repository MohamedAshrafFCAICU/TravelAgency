﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Core.Domain.Entities.Notification;

namespace TravelAgency.Core.Domain.Repository_Contracts
{
    public interface INotificationRepository
    {
        void AddNotification(Notification notification);
        IEnumerable<Notification> GetAllNotifications();
    }
}