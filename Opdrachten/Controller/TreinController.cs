﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class TreinController
    {
        public ITreinReis treinReis = new TreinReis();

        public void VolgendeStation()
        {
            treinReis.VolgendeStation();
        }
    }

}