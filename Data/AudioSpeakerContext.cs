using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Audio_Speaker.Models;

namespace Audio_Speaker.Data
{
 
        public class AudioSpeakerContext : DbContext
        {
            public AudioSpeakerContext(DbContextOptions<AudioSpeakerContext> options)
                : base(options)
            {
            }

            public DbSet<Speaker> Speaker { get; set; }
        }
    }

