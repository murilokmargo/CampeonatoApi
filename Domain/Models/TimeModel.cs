using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TimeModel
    {
        private Guid _id;

        public Guid ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private ICollection<PartidaEntity> _timesA;

        public ICollection<PartidaEntity> TimesA 
        {
            get { return _timesA; }
            set { _timesA = value; }
        }
        
        private ICollection<PartidaEntity> _timesB;

        public ICollection<PartidaEntity> TimesB 
        {
            get { return _timesB; }
            set { _timesB = value; }
        }


    }
}
