﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIRESTFULL.Models;
using WEBAPIRESTFULL.Utils;

namespace WEBAPIRESTFULL.Controllers
{
    public class MathFile : Single<MathFile>
    {
        BibliotecaContextDB BibliotecaContextDB = new BibliotecaContextDB();
        public int QuantidadeUsuarios()
        {
            return BibliotecaContextDB.Usuarios.Count();
        }
    }
}