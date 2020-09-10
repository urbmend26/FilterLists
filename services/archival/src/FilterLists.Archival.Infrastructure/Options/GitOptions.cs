﻿namespace FilterLists.Archival.Infrastructure.Options
{
    internal class GitOptions
    {
        public const string Key = nameof(Key);

        public string RepositoryDirectory { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}