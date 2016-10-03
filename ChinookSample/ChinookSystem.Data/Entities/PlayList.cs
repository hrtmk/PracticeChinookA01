﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion 


namespace ChinookSystem.Data.Entities
{
    public class PlayList
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}