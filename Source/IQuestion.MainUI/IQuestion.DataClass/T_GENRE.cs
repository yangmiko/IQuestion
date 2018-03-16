// **************************************************************************************
//  This entity class was generated automatically.
//  Please don't modify it because any change from data source site would cause the corresponding change on it.
//  To change the content or properties including behaviors and types, please use ProjectManagement client.
// 
//  Entity Basis:
//  Name: T_GENRE
//  Summary:
//  Data entity class of object T_GENRE.
// 
//  Copy Right: Yangs.Accumulation, 2004 - 2014
// 
// **************************************************************************************
using System;
using Yangs.Accumulation.Database.Enterprise;

namespace IQuestion.DataClass
{
    /// <summary>
    /// Data entity class of object T_GENRE.
    /// </summary>
    [EntityClass("T_GENRE")]
    public class T_GENRE  : YangsDataEntity
    {
        #region Private Variables
        /// <summary>
        /// GENREID
        /// </summary>
        private string m_gENREID;

        /// <summary>
        /// GenreName
        /// </summary>
        private string m_genreName;

        /// <summary>
        /// Description
        /// </summary>
        private string m_description;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the GENREID
        /// </summary>
        [DBField("GENREID", DBFieldBehave.CustomKey, DBFieldType.Char, 32, true)]
        public string GENREID
        {
            get
            {
                return m_gENREID;
            }
            set
            {
                m_gENREID = value;
            }
        }

        /// <summary>
        /// Gets or sets the GenreName
        /// </summary>
        [DBField("GenreName", DBFieldBehave.Field, DBFieldType.Varchar, 50, false)]
        public string GenreName
        {
            get
            {
                return m_genreName;
            }
            set
            {
                m_genreName = value;
            }
        }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        [DBField("Description", DBFieldBehave.Field, DBFieldType.Varchar, 500, true)]
        public string Description
        {
            get
            {
                return m_description;
            }
            set
            {
                m_description = value;
            }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return m_genreName;
        }
        #endregion
    }
}