using System;

namespace Interfaces.Example99
{
    public class MaintenanceService
    {
        private readonly IClientRepository clientRepository;

        public MaintenanceService(IClientRepository clientRepository) =>
            this.clientRepository = clientRepository;

        public void Maintain()
        {
            foreach (var client in clientRepository.GetClients())
            {
                BillService billService;
                if (client.Migrated)
                {
                    var settings = new EnvironmentVariableSqlServerSettings();
                    billService = new BillService(new SqlServerInvoiceRepository(settings), new SqlServerBillRepository(settings));
                }
                else
                {
                    var settings = new HardCodedFileSystemSettings();
                    billService = new BillService(new FileSystemInvoiceRepository(settings), new FileSystemBillRepository(settings));
                }
                billService.Generate(client.Id);
            }
        }
    }
}
