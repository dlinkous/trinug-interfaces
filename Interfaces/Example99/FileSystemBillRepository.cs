using System;

namespace Interfaces.Example99
{
    public class FileSystemBillRepository : IBillRepository
    {
        private readonly IFileSystemSettings settings;

        public FileSystemBillRepository(IFileSystemSettings settings) =>
            this.settings = settings;

        public void Save(int clientId, Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
