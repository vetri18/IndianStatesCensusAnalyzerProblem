using IndianStateCensusAnalyser;
using IndianStateCensusAnalyser.Constructor_for_different_CSV;

namespace IndianStateCensusAnalyserTest
{
    [TestClass]
    public class Tests
    {

        
        static string indiaStateCensusData = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCensusData.csv";
        static string wrongIndiaStateCensusData = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\WrongIndiaStateCensusData.csv";
        static string indiaStateCensusDataText = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCensusDAta.txt";
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



        /// <summary>
        /// checking the program for incorrect file name which do not exist
        /// test case 1.2
        /// </summary>
        [TestMethod]
        public void GivenWrongIndianCensusDataFile_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, customException.etype);
        }


        /// <summary>
        /// checking the program for incorrect file type which do not exist
        /// test case 1.3
        /// </summary>
        [TestMethod]
        public void GivenWrongIndianCensusDataType_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCensusDataText, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, customException.etype);
        }

    }
}