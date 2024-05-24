using System;

namespace IPMAWarningsApp.Models
{
    public class Aviso
    {
        public string Text { get; set; }
        public string AwarenessTypeName { get; set; }
        public string IdAreaAviso { get; set; }
        public DateTime StartTime { get; set; }
        public string AwarenessLevelID { get; set; }
        public DateTime EndTime { get; set; }
    }
}
