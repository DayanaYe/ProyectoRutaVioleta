﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public interface IServicioSeguridad
    {
        public bool ValidarUsuario(Autenticacion autenticacion);
    }
}
