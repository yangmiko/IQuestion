using System.Configuration;

namespace IQuestion.Business.Configs
{
    /// <summary>
    /// LevelSettings configuration context class.
    /// </summary>
    public class LevelSettingConfigContext : ConfigurationElement
    {
        #region Constructor
        /// <summary>
        /// Initlalize configuration items with specified values.
        /// </summary>
        /// <param name="LevelName">Name of the level</param>
        /// <param name="LevelValue">Value of the level</param>
        public LevelSettingConfigContext(string argLevelName, string argLevelValue)
        {
            LevelName = argLevelName;
            LevelValue = argLevelValue;
        }

        /// <summary>
        /// Initlalize configuration items with default values.
        /// </summary>
        public LevelSettingConfigContext()
        {
            // Initialize as follows, if no attributed
            // values are provided.
            // this.Name = "Microsoft";
            // this.Url = "http://www.microsoft.com";
            // this.Port = 0;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the Name of the level.
        /// </summary>
        [ConfigurationProperty("LevelName")]
        public string LevelName
        {
            get
            {
                return (string)this["LevelName"];
            }
            set
            {
                // With this you disable the setting.
                // Renemmber that the _ReadOnly flag must
                // be set to true in the GetRuntimeObject.
                // ThrowIfReadOnly("LevelName");
                this["LevelName"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the Value of the level.
        /// </summary>
        [ConfigurationProperty("LevelValue")]
        public string LevelValue
        {
            get
            {
                return (string)this["LevelValue"];
            }
            set
            {
                // With this you disable the setting.
                // Renemmber that the _ReadOnly flag must
                // be set to true in the GetRuntimeObject.
                // ThrowIfReadOnly("LevelName");
                this["LevelValue"] = value;
            }
        }
        #endregion
    }
}
