﻿using Nancy;

namespace PenguinUpload.DataModels.Api
{
    public class FileUploadRequest
    {
        public HttpFile File { get; set; }
        public string TargetDirectory { get; set; }
    }
}