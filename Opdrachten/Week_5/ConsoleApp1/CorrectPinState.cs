﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CorrectPinState : IATMState
    {
        private ATMMachine ATM;

        public CorrectPinState(ATMMachine atm)
        {
            this.ATM = atm;
        }

        public void EnterPincode(int pin)
        {

        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void RejectCard()
        {
            throw new NotImplementedException();
        }

        public void SetAmountInMachine(int amount)
        {
            throw new NotImplementedException();
        }

        public void WithdrawCash(int cash)
        {
            throw new NotImplementedException();
        }
    }
}
