using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [WithXMarker]
    public interface IWithExitCode : IWithXMarker,
        IHasExitCode
    {
        /// <inheritdoc cref="IHasExitCode.ExitCode"/>
        new int ExitCode  { get; set; }
    }
}
