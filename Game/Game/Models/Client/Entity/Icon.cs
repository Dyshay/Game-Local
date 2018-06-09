using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Client.Entity
{
    public class Icon
    {
        public int? IconID { get; set; }
        public string Nom { get; set; }
        public string Access { get; set; }
        public int Level { get; set; }

        public Icon(int? iconid,string nom,string access,int level)
        {
            IconID = iconid;
            Nom = nom;
            Access = access;
            Level = level;
        }
    }
}
