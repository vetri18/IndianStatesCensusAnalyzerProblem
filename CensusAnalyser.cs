﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US
        }
        public Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CsvAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }

    }
}