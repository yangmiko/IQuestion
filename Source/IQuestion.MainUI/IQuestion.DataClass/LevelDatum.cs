using System;

namespace IQuestion.DataClass
{
    public class LevelDatum
    {
        #region Private Variables
        /// <summary>
        /// Value of the level
        /// </summary>
        private int m_levelValue;

        /// <summary>
        /// Description of the level
        /// </summary>
        private string m_levelDescription;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the Value of the level.
        /// </summary>
        public int LevelValue
        {
            get
            {
                return m_levelValue;
            }
            set
            {
                m_levelValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the Description of the level.
        /// </summary>
        public string LevelDescription
        {
            get
            {
                return m_levelDescription;
            }
            set
            {
                m_levelDescription = value;
            }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return m_levelDescription;
        }
        #endregion
    }
}