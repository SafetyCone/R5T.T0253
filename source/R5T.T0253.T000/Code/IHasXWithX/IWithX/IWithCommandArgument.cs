using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [WithXMarker]
    public interface IWithCommandArgument : IWithXMarker,
        IHasCommandArgument
    {
        /// <inheritdoc cref="IHasCommandArgument.CommandArgument"/>
        new string CommandArgument { get; set; }
    }
}
