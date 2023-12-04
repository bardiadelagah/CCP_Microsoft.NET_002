# A Razor Page Exmaple

This is the simple Example of Razor Pages.

### Infromation

Programing Language: C# <br>
ASP.NET Core Web UI: Razor Pages <br>
.NET SDK Version : 8.0.100 <br>
Microsfot SQL Server 2022 (RTM-GDR)(KB5029379) - 16.0.1105.1 (x64) <br>

Download and install

- .NET SDK
- Microsoft SQL Server

### Structure

The folder and files are below:

```bash
├── bin
├── Data                 # for manage Databse
├── rMigrations          # requirements and dependensies
├── obj
├── Pages                # Include subfolders for each routes, .cshtml and .cshtml.cs filetypes
└── Properties           # Implementation the alghoritem of article
└── WWWroot              # Static Files
└── .gitignore
└── appsettings.Development.json
└── appsettings.json
└── BulkyWebRazor_Temp.csproj
└── Program.cs
└── README.md
```

### Pages

This Project Include Pages and Routes as Below: <br>

- localhost:Portnumber

  - /Category
    - /Index
    - /Create
    - /Edit
    - /Delete
  - /Index
  - /Privacy

### How it works

1. Clone the project on your local machine(Windows/Linux/MacOS)
2. set database connectionString in "appsettings.json" file

```JSON
  "ConnectionStrings": {
    "DefaultConnection": "Server=<YOUR_SERVER_NAME>;Database=<YOUR_DATABASE_NAME>;Trusted_Connection=True;TrustServerCertificate=True"
  }
```

3. Open Power Shell or CMD in the root of project open Package Manager Console on Visual Studio and run these command Dotnet CLI <br>
   Dotnet CLI

```
## Dotnet CLI on Power Shell or CMD
dotnet ef database update
## or
## Manager Console on Visual Studio
database-update
```

Now you can see some data added to tables of database
