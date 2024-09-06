using Dotmim.Sync;
using Dotmim.Sync.SqlServer;
using Dotmim.Sync.Web.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Tạo cấu hình từ appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Đảm bảo đường dẫn đến appsettings.json là chính xác
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Lấy chuỗi kết nối từ cấu hình
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Cấu hình SyncProvider
        var webProvider = new WebSyncProvider(new Uri("http://LAPTOP-1HMMOG6J:5000/api/sync")); // Địa chỉ API của server
        var localProvider = new SqlSyncProvider(connectionString); // Sử dụng chuỗi kết nối từ appsettings.json

        // Tạo SyncAgent và đồng bộ hóa
        var agent = new SyncAgent(localProvider, webProvider);

        // Đồng bộ hóa
        var result = await agent.SynchronizeAsync();

        // In kết quả đồng bộ hóa ra console
        Console.WriteLine($"Total changes downloaded: {result.TotalChangesDownloadedFromServer}");
    }
}
