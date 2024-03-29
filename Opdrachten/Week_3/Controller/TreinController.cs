﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using View;

namespace Controller
{
    public class TreinController : ITreinController
    {
        ITreinReis Reis { get; set; }
        public TreinController(ITreinReis reis)
        {
            reis = new TreinReis();
            this.Reis = reis;
        }

        public void VolgendeStation()
        {
            Reis.VolgendeStation();
        }
        public Station HuidigStation()
        {
            return Reis.HuidigStation();
        }
    }

}
