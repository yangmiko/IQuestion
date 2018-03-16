using System;
using System.Collections.Generic;
using IQuestion.DataClass;
using System.Configuration;

namespace IQuestion.Business.Configs
{
    public class LevelReader
    {
        private static List<LevelDatum> s_levels;
        private static bool s_completed;

        public LevelReader()
        {
            if (!s_completed)
            {
                lock (typeof(LevelReader))
                {
                    if (s_completed)
                    {
                        return;
                    }

                    LevelSettingConfigHandler contextHandler =
                       ConfigurationManager.GetSection("LevelSettings") as LevelSettingConfigHandler;

                    s_levels = new List<LevelDatum>();
                    for (int intIndex = 0; intIndex < contextHandler.Contexts.Count; intIndex++)
                    {
                        LevelDatum objLevel = new LevelDatum();
                        objLevel.LevelDescription = contextHandler.Contexts[intIndex].LevelName;
                        objLevel.LevelValue = Convert.ToInt32(contextHandler.Contexts[intIndex].LevelValue);
                        s_levels.Add(objLevel);
                    }

                    s_completed = true;
                }
            }
        }

        public int Count
        {
            get
            {
                return s_levels.Count;
            }
        }

        public LevelDatum this[int argIndex]
        {
            get
            {
                return s_levels[argIndex];
            }
        }
    }
}
