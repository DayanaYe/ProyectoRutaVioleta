﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("ViolenciaPsicologicas")]
    public class ViolenciaPsicologica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<RutaVioleta> RutaVioleta { get; set; }
    }
}
