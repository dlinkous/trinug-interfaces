using System;

namespace Interfaces.Example99
{
    public class HardCodedFileSystemSettings : IFileSystemSettings
    {
        public string Root => Environment.CurrentDirectory;
    }
}
