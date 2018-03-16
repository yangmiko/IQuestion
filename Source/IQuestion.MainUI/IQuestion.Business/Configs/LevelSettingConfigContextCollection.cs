using System;
using System.Configuration;

namespace IQuestion.Business.Configs
{
    /// <summary>
    /// LevelSettings configuration context collection class.
    /// </summary>
    public class LevelSettingConfigContextCollection : ConfigurationElementCollection
    {
        #region Constructor
        /// <summary>
        /// Initialize new context collection object.
        /// </summary>
        public LevelSettingConfigContextCollection()
        {
            LevelSettingConfigContext context = (LevelSettingConfigContext)CreateNewElement();
            Add(context);
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Gets the collection type.
        /// </summary>
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        /// <summary>
        /// Create new LevelSettings configuration context object.
        /// </summary>
        /// <returns>New LevelSettings Configuration Context Object</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new LevelSettingConfigContext();
        }

        /// <summary>
        /// Get element key - LevelName.
        /// </summary>
        /// <param name="element">Element Object</param>
        /// <returns>Name of the level</returns>
        protected override object  GetElementKey(ConfigurationElement element)
        {
            return ((LevelSettingConfigContext)element).LevelName;
        }

        /// <summary>
        /// Add an element.
        /// </summary>
        /// <param name="element">Element Object</param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the LevelSetting configuration context item by item index.
        /// </summary>
        /// <param name="index">Item Index</param>
        /// <returns>LevelSetting Configuration Context Item</returns>
        public LevelSettingConfigContext this[int index]
        {
            get
            {
                return (LevelSettingConfigContext)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Gets the LevelSetting configuration context item by key - Name of the level.
        /// </summary>
        /// <param name="argLevelName">Name of the level</param>
        /// <returns>LevelSetting Configuration Context Item</returns>
        new public LevelSettingConfigContext this[string argLevelName]
        {
            get
            {
                return (LevelSettingConfigContext)BaseGet(argLevelName);
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Calculate the location of specified LevelSetting configuration context item.
        /// </summary>
        /// <param name="argContext">LevelSettingElement Object</param>
        /// <returns>Location of specified LevelSetting configuration context item.</returns>
        public int IndexOf(LevelSettingConfigContext argContext)
        {
            return BaseIndexOf(argContext);
        }

        /// <summary>
        /// Add a LevelSetting configuration context item into the collection.
        /// </summary>
        /// <param name="argContext">LevelSettingElement Object</param>
        public void Add(LevelSettingConfigContext argContext)
        {
            BaseAdd(argContext);
        }

        /// <summary>
        /// Remove specified LevelSetting configuration context item from collection.
        /// </summary>
        /// <param name="argContext">LevelSettingElement Object</param>
        public void Remove(LevelSettingConfigContext argContext)
        {
            if (BaseIndexOf(argContext) >= 0)
                BaseRemove(argContext.LevelName);
        }

        /// <summary>
        /// Remove specified LevelSetting configuration context item index from collection.
        /// </summary>
        /// <param name="index">Item Index</param>
        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>
        /// Remove specified LevelSetting configuration context item key - @KeyItem from collection.
        /// </summary>
        /// <param name="argLevelName">Name of the level</param>
        public void Remove(string argLevelName)
        {
            BaseRemove(argLevelName);
        }

        /// <summary>
        /// Clear the LevelSetting collection.
        /// </summary>
        public void Clear()
        {
            BaseClear();
        }
        #endregion
    }
}
