using IndianStateCensusAnalyser;
using IndianStateCensusAnalyser.Constructor_for_different_CSV;

namespace IndianStateCensusAnalyserTest
{
    [TestClass]
    public class Tests
    {

        
        static string indiaStateCensusData = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCensusData.csv";
        static string wrongIndiaStateCensusData = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\WrongIndiaStateCensusData.csv";
        static string wrongFileIndiaStateCensusData = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSVFiles\WrongIndiaStateCensusData.csv";
        static string indiaStateCensusDataText = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCensusDAta.txt";
        static string delimiterIndiaStateCensusData = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\DelimiterIndiaStateCensusData.csv";
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        //StateCode
        static string indiaStateCode = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCode.csv";
        static string indiaStateCodeText = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCode.txt";
        static string delimiterIndiaStateCode = @"C:\Users\tusha\source\repos\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\DelimiterIndiaStateCode.csv";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        


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
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongFileIndiaStateCensusData, indianStateCensusHeaders));
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


        /// <summary>
        /// checking the program for incorrect delimiter is passed
        /// test case 1.4
        /// </summary>
        [TestMethod]
        public void GivenIncorrectDelimiterForCensusData_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimiterIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, customException.etype);
        }


        /// <summary>
        /// checking the program for incorrect header is passed
        /// test case 1.5
        /// </summary>
        [TestMethod]
        public void GivenIncorrectHeaderForCensusData_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, customException.etype);
        }


        /// <summary>
        /// Test Case 2.1
        /// Getting the count of data in IndiaStateCodeData
        /// </summary>

        [TestMethod]
        public void GivenIndianCodeDataFile_WhenReturnShouldReturnCodeCount()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCode, indianStateCodeHeaders);
            //assert
            //total no of rows excluding header are 37 in indian state census data.
            Assert.AreEqual(37, totalRecord.Count);
        }


        /// <summary>
        /// checking the program for incorrect file name which do not exist
        /// test case 2.2
        /// </summary>
        [TestMethod]
        public void GivenWrongIndianCodeDataFile_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongFileIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, customException.etype);
        }


        /// <summary>
        /// checking the program for incorrect file type which do not exist
        /// test case 2.3
        /// </summary>
        [TestMethod]
        public void GivenWrongIndianCodeDataType_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCodeText, indianStateCodeHeaders));
            //total no of rows excluding header are 36 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, customException.etype);
        }

        /// <summary>
        /// checking the program for incorrect delimiter is passed
        /// test case 2.4
        /// </summary>
        [TestMethod]
        public void GivenIncorrectDelimiterForCodeData_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimiterIndiaStateCode, indianStateCodeHeaders));
            //total no of rows excluding header are 36 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, customException.etype);
        }

    }
}