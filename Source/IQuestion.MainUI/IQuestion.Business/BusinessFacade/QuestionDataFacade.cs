using System;
using System.Collections.Generic;
using System.Data;
using Yangs.Accumulation.Database;
using Yangs.Accumulation.DataDrive.SQLite;
using IQuestion.DataClass;

namespace IQuestion.Business.BusinessFacade
{
    public class QuestionDataFacade : DataFacade
    {
        public bool NewAQuestion(T_QUESTION argQuestion, ref string argMessage)
        {
            bool blnResult = false;

            using (YangsTransactionManager objMgr = YangsTransactionManager.Create(YangsTransactionMode.RequiresNew,
                IsolationLevel.ReadCommitted, p_connectionName, true))
            {
                try
                {
                    SQLiteEntityAccess<T_QUESTION> objQuestionAccess = new SQLiteEntityAccess<T_QUESTION>();
                    objQuestionAccess.Create(argQuestion);
                    blnResult = true;
                }
                catch (Exception ex)
                {
                    YangsTransactionManager.SetAbort();
                    argMessage = ex.Message;
                }
            }

            return blnResult;
        }
    }
}
