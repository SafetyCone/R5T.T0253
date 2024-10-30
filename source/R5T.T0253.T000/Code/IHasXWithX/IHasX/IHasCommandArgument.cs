using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [HasXMarker]
    public interface IHasCommandArgument : IHasXMarker
    {
        /// <summary>
        /// The argument text for a command (i.e. a concatenation of all command arguments).
        /// </summary>
        string CommandArgument { get; }
    }
}
