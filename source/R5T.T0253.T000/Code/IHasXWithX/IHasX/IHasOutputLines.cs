﻿using System;

using R5T.T0240;


namespace R5T.T0253.T000
{
    [HasXMarker]
    public interface IHasOutputLines : IHasXMarker
    {
        string[] OutputLines { get; }
    }
}
