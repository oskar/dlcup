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
    public partial class Game
    {
        #region Primitive Properties
    
        public virtual int GameId
        {
            get;
            set;
        }
    
        public virtual Nullable<int> HomeScore
        {
            get;
            set;
        }
    
        public virtual Nullable<int> GuestScore
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Match Match
        {
            get { return _match; }
            set
            {
                if (!ReferenceEquals(_match, value))
                {
                    var previousValue = _match;
                    _match = value;
                    FixupMatch(previousValue);
                }
            }
        }
        private Match _match;

        #endregion
        #region Association Fixup
    
        private void FixupMatch(Match previousValue)
        {
            if (previousValue != null && previousValue.Games.Contains(this))
            {
                previousValue.Games.Remove(this);
            }
    
            if (Match != null)
            {
                if (!Match.Games.Contains(this))
                {
                    Match.Games.Add(this);
                }
            }
        }

        #endregion
    }
}
