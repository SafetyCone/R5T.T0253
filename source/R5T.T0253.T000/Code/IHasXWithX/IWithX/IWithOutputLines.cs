using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [WithXMarker]
    public interface IWithOutputLines : IWithXMarker,
        IHasOutputLines
    {
        /// <inheritdoc cref="IHasOutputLines.OutputLines"/>
        new string[] OutputLines { get; set; }
    }
}
