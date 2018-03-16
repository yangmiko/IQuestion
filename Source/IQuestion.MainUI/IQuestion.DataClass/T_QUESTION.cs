// **************************************************************************************
//  This entity class was generated automatically.
//  Please don't modify it because any change from data source site would cause the corresponding change on it.
//  To change the content or properties including behaviors and types, please use ProjectManagement client.
// 
//  Entity Basis:
//  Name: T_QUESTION
//  Summary:
//  Data entity class of object T_QUESTION.
// 
//  Copy Right: Yangs.Accumulation, 2004 - 2014
// 
// **************************************************************************************
using System;
using Yangs.Accumulation.Database.Enterprise;

namespace IQuestion.DataClass
{
    /// <summary>
    /// Data entity class of object T_QUESTION.
    /// </summary>
    [EntityClass("T_QUESTION")]
    public class T_QUESTION  : YangsDataEntity
    {
        #region Private Variables
        /// <summary>
        /// QuestionID
        /// </summary>
        private string m_questionID;

        /// <summary>
        /// QuestionEN
        /// </summary>
        private string m_questionEN;

        /// <summary>
        /// QuestionCN
        /// </summary>
        private string m_questionCN;

        /// <summary>
        /// AnswerEN
        /// </summary>
        private string m_answerEN;

        /// <summary>
        /// AnswerCN
        /// </summary>
        private string m_answerCN;

        /// <summary>
        /// Level
        /// </summary>
        private int m_level;

        /// <summary>
        /// GenreID
        /// </summary>
        private string m_genreID;

        /// <summary>
        /// Valid
        /// </summary>
        private string m_valid;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the QuestionID
        /// </summary>
        [DBField("QuestionID", DBFieldBehave.CustomKey, DBFieldType.Char, 32, true)]
        public string QuestionID
        {
            get
            {
                return m_questionID;
            }
            set
            {
                m_questionID = value;
            }
        }

        /// <summary>
        /// Gets or sets the QuestionEN
        /// </summary>
        [DBField("QuestionEN", DBFieldBehave.Field, DBFieldType.Varchar, 2000, false)]
        public string QuestionEN
        {
            get
            {
                return m_questionEN;
            }
            set
            {
                m_questionEN = value;
            }
        }

        /// <summary>
        /// Gets or sets the QuestionCN
        /// </summary>
        [DBField("QuestionCN", DBFieldBehave.Field, DBFieldType.Nvarchar, 2000, true)]
        public string QuestionCN
        {
            get
            {
                return m_questionCN;
            }
            set
            {
                m_questionCN = value;
            }
        }

        /// <summary>
        /// Gets or sets the AnswerEN
        /// </summary>
        [DBField("AnswerEN", DBFieldBehave.Field, DBFieldType.Varchar, 2000, true)]
        public string AnswerEN
        {
            get
            {
                return m_answerEN;
            }
            set
            {
                m_answerEN = value;
            }
        }

        /// <summary>
        /// Gets or sets the AnswerCN
        /// </summary>
        [DBField("AnswerCN", DBFieldBehave.Field, DBFieldType.Nvarchar, 2000, true)]
        public string AnswerCN
        {
            get
            {
                return m_answerCN;
            }
            set
            {
                m_answerCN = value;
            }
        }

        /// <summary>
        /// Gets or sets the Level
        /// </summary>
        [DBField("Level", DBFieldBehave.Field, DBFieldType.Integer, false)]
        public int Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }

        /// <summary>
        /// Gets or sets the GenreID
        /// </summary>
        [DBField("GenreID", DBFieldBehave.Field, DBFieldType.Char, 32, true)]
        public string GenreID
        {
            get
            {
                return m_genreID;
            }
            set
            {
                m_genreID = value;
            }
        }

        /// <summary>
        /// Gets or sets the Valid
        /// </summary>
        [DBField("Valid", DBFieldBehave.Field, DBFieldType.Char, 1, true)]
        public string Valid
        {
            get
            {
                return m_valid;
            }
            set
            {
                m_valid = value;
            }
        }
        #endregion
    }
}