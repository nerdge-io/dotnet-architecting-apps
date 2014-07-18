﻿using Merp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merp.Accountancy.CommandStack.Events
{
    public class TimeAndMaterialJobOrderCreatedEvent : DomainEvent
    {
        public Guid JobOrderId { get; private set; }
        public int CustomerId { get; private set; }
        public decimal? Value { get; private set; }
        public DateTime DateOfStart { get; private set; }
        public DateTime? DateOfExpiration { get; private set; }
        public string JobOrderName { get; private set; }
        public string JobOrderNumber { get; set; }

        public TimeAndMaterialJobOrderCreatedEvent(Guid jobOrderId, int customerId, decimal? value, DateTime dateOfStart, DateTime? dateOfExpiration, string jobOrderName, string jobOrderNumber)
        {
            JobOrderId = jobOrderId;
            CustomerId = customerId;
            Value = value;
            DateOfStart = dateOfStart;
            DateOfExpiration = dateOfExpiration;
            JobOrderName = jobOrderName;
            JobOrderNumber = jobOrderNumber;
        }
    }
}