﻿using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace AzureLogSpelunker.Models
{
    public class LogEntity : TableEntity
    {
        public Int64 EventTickCount { get; set; }
        public string DeploymentId { get; set; }
        public string Role { get; set; }
        public string RoleInstance { get; set; }
        public int Level { get; set; }
        public int EventId { get; set; }
        public int Pid { get; set; }
        public int Tid { get; set; }
        public string Message { get; set; }
    }
}
