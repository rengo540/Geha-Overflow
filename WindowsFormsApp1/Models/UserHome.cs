using System;
using System.Collections.Generic;
using System.Text;

namespace GehaOverFlow.Models
{
    /// <summary>
    /// Represents the current user logged in 
    /// </summary>
    public sealed class UserHome
    {
        public static User User { get; set; }
    }
}
