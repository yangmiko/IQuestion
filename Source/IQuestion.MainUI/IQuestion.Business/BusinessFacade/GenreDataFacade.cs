using System;
using System.Collections.Generic;
using System.Data;
using Yangs.Accumulation.Database;
using Yangs.Accumulation.DataDrive.SQLite;
using IQuestion.DataClass;

namespace IQuestion.Business.BusinessFacade
{
    public class GenreDataFacade : DataFacade
    {
        public bool GetAllRenres(ref List<T_GENRE> argGenres, ref string argMessage)
        {
            bool blnResult = false;

            using (YangsTransactionManager objMgr = YangsTransactionManager.Create(YangsTransactionMode.RequiresNew,
                IsolationLevel.ReadCommitted, p_connectionName, false))
            {
                try
                {
                    SQLiteEntityAccess<T_GENRE> objGenreAccess = new SQLiteEntityAccess<T_GENRE>();
                    objGenreAccess.SelectAll(ref argGenres);
                    blnResult = true;
                }
                catch (Exception ex)
                {
                    argMessage = ex.Message;
                }
            }

            return blnResult;
        }
    }
}
