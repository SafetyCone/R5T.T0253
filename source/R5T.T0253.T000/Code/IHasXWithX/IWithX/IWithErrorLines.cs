using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [WithXMarker]
    public interface IWithErrorLines : IWithXMarker,
        IHasErrorLines
    {
        /// <inheritdoc cref="IHasErrorLines.ErrorLines"/>
        new string[] ErrorLines { get; set; }
    }
}
