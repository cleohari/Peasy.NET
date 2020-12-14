﻿using System.Collections.Generic;

namespace Peasy
{
    /// <summary>
    /// Represents a rule list that has been configured to run after successful completion of a parent rule 
    /// </summary>
    public interface IRuleSuccessor : IEnumerable<IRule>
    {
        /// <summary>
        /// Returns a list of rules that will run after successful completion of the parent rule
        /// </summary>
        IEnumerable<IRule> Rules { get; }
    }
}
