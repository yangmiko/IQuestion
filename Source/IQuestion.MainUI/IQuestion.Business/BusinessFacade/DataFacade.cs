using System.Configuration;

namespace IQuestion.Business.BusinessFacade
{
    public class DataFacade
    {
        protected string p_connectionName;

        public DataFacade()
        {
            p_connectionName = ConfigurationManager.AppSettings["DefaultConnection"];
        }
    }
}
