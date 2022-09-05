using IndianStateCensusAnalyser;
using IndianStateCensusAnalyser.Constructor_for_different_CSV;

namespace IndianStateCensusAnalyserTest
{
    [TestClass]
    public class Tests
    {

        
        static string indiaStateCensusData = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCensusData.csv";
        
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";


        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;


        /// <summary>
        /// TestInitialized will always run, when any test case is checked.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();

        }


        /// <summary>
        /// Test Case 1.1
        /// Getting the count of data in IndiaStateCensusData
        /// </summary>
        [TestMethod]
        public void GivenIndianCensusDataFile_WhenReturnShouldReturnCensusDataCount()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCensusData, indianStateCensusHeaders);
            //assert
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(29, totalRecord.Count);
        }
    }
}