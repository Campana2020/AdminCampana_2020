﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCampana_2020.Domain
{
    public class DireccionDomainModel
    {
        public  int Id { get; set; }
        public string StrCalle { get; set; }
        public string StrNumeroInterior { get; set; }
        public string StrNumeroExterior { get; set; }
        public string StrObservacion { get; set; }
        public ColoniaDomainModel ColoniaDomainModel { get; set; }
        public SeccionDomainModel SeccionDomainModel { get; set; }
        public ZonaDomainModel ZonaDomainModel { get; set; }
    }
}
