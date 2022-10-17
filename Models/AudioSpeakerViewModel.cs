using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace Audio_Speaker.Models
{
    public class AudioSpeakerViewModel
    {
        public List<Speaker> Speaker { get; set; }
        public SelectList Company { get; set; }
        public string SpeakerCompany { get; set; }
        public string SearchString { get; set; }
        public List<Speaker> Speakers { get; internal set; }
    } 
}
