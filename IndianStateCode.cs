using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser.Constructor_for_different_CSV
{
    public class IndianStateCode
    {
        public string stateName;
        public string stateCode;
        public int tin;
        public int serialNumber;

        public IndianStateCode(string stateName, string stateCode, string tin, string serialNumber)
        {
            this.stateName = stateName;
            this.stateCode = stateCode;
            this.tin = Convert.ToInt32(tin);
            this.serialNumber = Convert.ToInt32(serialNumber);
        }
    }


}