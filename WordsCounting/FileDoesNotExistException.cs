﻿using System.Runtime.Serialization;

namespace WordsCounting;

[Serializable]
public class FileDoesNotExistException : Exception
{
    public FileDoesNotExistException(string fileName) : base($"File {fileName} does not exist")
    {
        FileName = fileName;
    }

    protected FileDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        FileName = info.GetString(nameof(FileName))!;
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue(nameof(FileName), FileName);
    }

    public string FileName { get; }
}