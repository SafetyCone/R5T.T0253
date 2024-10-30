using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [WithXMarker]
    public interface IWithCommand : IWithXMarker,
        IHasCommand
    {
        /// <inheritdoc cref="IHasCommand.Command"/>
        new string Command { get; set; }
    }
}
