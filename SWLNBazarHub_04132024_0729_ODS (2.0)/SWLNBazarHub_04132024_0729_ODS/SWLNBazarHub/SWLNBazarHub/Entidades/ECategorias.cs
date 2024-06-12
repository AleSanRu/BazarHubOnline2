﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class ECategorias
    {
        [DataMember]
        public int CategoriaID { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public ECategorias()
        {
            CategoriaID = 0;
            Nombre = string.Empty;
            Estado = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}