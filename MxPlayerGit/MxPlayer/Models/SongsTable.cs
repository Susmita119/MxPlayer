using System;
using System.Collections.Generic;

namespace MxPlayer.Models
{
    public partial class SongsTable
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public int? DefaultSequence { get; set; }
    }
}
