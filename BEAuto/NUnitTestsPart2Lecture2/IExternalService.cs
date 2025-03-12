namespace NUnitTestsPart2Lecture2
{
    public interface IExternalService
    {
        string FetchData();
        string GetData();
    }

    public class DataProcessor
    {
        private readonly IExternalService _externalService;
        public DataProcessor(IExternalService externalService)
        {
            _externalService = externalService;
        }
        public string ProcessData()
        {
            var data = _externalService.FetchData();
            return data.ToUpper();
        }
    }
}