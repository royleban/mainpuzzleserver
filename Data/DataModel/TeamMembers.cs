﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCore.DataModel
{
    public class TeamMembers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Foreign Key - Team table 
        /// </summary>
        [ForeignKey("Team.ID")]
        public virtual Team Team { get; set; }

        /// <summary>
        /// Foreign Key - User table
        /// </summary>
        [ForeignKey("User.ID")]
        public virtual PuzzleUser Member { get; set; }
    }
}
