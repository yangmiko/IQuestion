using System.Configuration;

namespace IQuestion.Business.Configs
{
    /// <summary>
    /// LevelSettings configuration handler class.
    /// </summary>
    public class LevelSettingConfigHandler : ConfigurationSection
    {
        /// <summary>
        /// LevelSettings configuration context object.
        /// </summary>
        LevelSettingConfigContext m_context;

        /// <summary>
        /// Create new LevelSettings configuration context object.
        /// </summary>
        public LevelSettingConfigHandler()
        {
            // Create a collection element.
            // The property values assigned to
            // this instance are provided.
            // by the ConfigurationProperty attributes
            // associated wiht the ConfigContext properties.
            m_context = new LevelSettingConfigContext();
        }

        // Declare the Regists collection property.
        // Note: the "IsDefaultCollection = false" instructs
        // .NET Framework to build a nested section of
        // the kind <Projects> ...</Projects>.
        /// <summary>
        /// Gets the LevelSettings configuration context collection.
        /// </summary>
        [ConfigurationProperty("Levels", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(LevelSettingConfigContextCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public LevelSettingConfigContextCollection Contexts
        {
            get
            {
                LevelSettingConfigContextCollection contextCollection =
                    (LevelSettingConfigContextCollection)base["Levels"];
                return contextCollection;
            }
        }
    }
}
