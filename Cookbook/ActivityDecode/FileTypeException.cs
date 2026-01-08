/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////

using System;

public class FileTypeException : Exception
{
    public FileTypeException()
    {
    }

    public FileTypeException(string message)
        : base(message)
    {
    }

    public FileTypeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}