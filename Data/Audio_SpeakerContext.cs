using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Audio_Speaker.Models;

namespace Audio_Speaker.Data
{
    public class Audio_SpeakerContext : DbContext
    {
        public Audio_SpeakerContext (DbContextOptions<Audio_SpeakerContext> options)
            : base(options)
        {
        }

        public DbSet<Audio_Speaker.Models.Speaker> Speaker { get; set; }
    }
}
