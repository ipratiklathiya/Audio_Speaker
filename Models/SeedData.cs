using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Audio_Speaker.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Audio_Speaker.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AudioSpeakerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AudioSpeakerContext>>()))
            {
                // Look for any movies.
                if (context.Speaker.Any())
                {
                    return;   // DB has been seeded
                }

                context.Speaker.AddRange(
                    new Speaker
                    {
                        Name = "JBL",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Dolby Atmos",
                        Company = "JBL Private Limited",
                        Price = 7.99M
                    },

                    new Speaker
                    {
                        Name = "Sony",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Bluetooth",
                        Company = "Sony Enterprise",
                        Price = 7.99M
                    },

                    new Speaker
                    {
                        Name = "Panasonic",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "USB Port",
                        Company = "Panasonic Verdict",
                        Price = 7.99M
                    },

                    new Speaker
                    {
                        Name = "Boat",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "USB, Bluetooth",
                        Company = "Boat India",
                        Price = 7.99M
                    },
                    new Speaker
                    {
                        Name = "Zebronics",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "USB Port",
                        Company = "Z Zebra",
                        Price = 7.99M
                    },
                    new Speaker
                    {
                        Name = "Alexa",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Speaker",
                        Company = "Amazon",
                        Price = 7.99M
                    },
                    new Speaker
                    {
                        Name = "Apple",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Bluetooth",
                        Company = "Marshalls",
                        Price = 7.99M
                    },
                    new Speaker
                    {
                        Name = "Phillips",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "USB",
                        Company = "Light Works",
                        Price = 7.99M
                    },
                    new Speaker
                    {
                        Name = "Noise",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "C type Cable",
                        Company = "Noise Limited",
                        Price = 7.99M
                    },
                    new Speaker
                    {
                        Name = "Beats",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Red USB",
                        Company = "Zebra Electronics",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
