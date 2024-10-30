using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [WithXMarker]
    public interface IWithDuration : IWithXMarker,
        IHasDuration
    {
        /// <inheritdoc cref="IHasDuration.Duration"/>
        new TimeSpan Duration { get; set; }
    }
}
