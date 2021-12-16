using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseOefening.Model
{
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200)]
        public string QuestionBody { get; set; }
    }
}
