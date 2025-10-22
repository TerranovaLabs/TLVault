var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TLVault_Wpf>("tlvault-wpf");

builder.Build().Run();
