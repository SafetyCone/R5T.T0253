using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [HasXMarker]
    public interface IHasCommand : IHasXMarker
    {
        /// <summary>
        /// The command text (either executable file path, or executable file name for an executable file on the system path).
        /// </summary>
        string Command { get; }
    }
}
