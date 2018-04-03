using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vivart.Models;

namespace Vivart.Context
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}