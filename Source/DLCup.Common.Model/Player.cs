//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DLCup.Common.Model
{
    public partial class Player
    {
        #region Primitive Properties
    
        public virtual int PlayerId
        {
            get;
            set;
        }
    
        public virtual string PlayerName
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Team Team
        {
            get { return _team; }
            set
            {
                if (!ReferenceEquals(_team, value))
                {
                    var previousValue = _team;
                    _team = value;
                    FixupTeam(previousValue);
                }
            }
        }
        private Team _team;

        #endregion
        #region Association Fixup
    
        private void FixupTeam(Team previousValue)
        {
            if (previousValue != null && previousValue.Players.Contains(this))
            {
                previousValue.Players.Remove(this);
            }
    
            if (Team != null)
            {
                if (!Team.Players.Contains(this))
                {
                    Team.Players.Add(this);
                }
            }
        }

        #endregion
    }
}