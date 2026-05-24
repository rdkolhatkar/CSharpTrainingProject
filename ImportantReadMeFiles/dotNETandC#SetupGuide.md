# .NET & C# — Complete Setup & Developer Guide

> **Who is this for?**
> Freshers, students, Java developers migrating to .NET, QA automation engineers, backend developers, and senior engineers exploring advanced patterns.

---

## Table of Contents

1. [What is .NET?](#1-what-is-net)
2. [What is C#?](#2-what-is-c)
3. [.NET Architecture](#3-net-architecture)
4. [Installing the .NET SDK](#4-installing-the-net-sdk)
   - [Windows](#windows)
   - [macOS](#macos)
   - [Linux (Ubuntu)](#linux-ubuntu)
5. [Environment Variables](#5-environment-variables)
6. [Verify Your Installation](#6-verify-your-installation)
7. [IDEs & Editors](#7-ides--editors)
8. [Your First C# Program](#8-your-first-c-program)
9. [Project Structure Explained](#9-project-structure-explained)
10. [Build, Run & Publish](#10-build-run--publish)
11. [Dependency Management with NuGet](#11-dependency-management-with-nuget)
12. [CLI Command Reference](#12-cli-command-reference)
13. [Project Templates](#13-project-templates)
14. [Debugging](#14-debugging)
15. [Advanced Concepts](#15-advanced-concepts)
16. [iOS & Mobile with .NET MAUI](#16-ios--mobile-with-net-maui)
17. [Troubleshooting](#17-troubleshooting)
18. [Best Practices](#18-best-practices)
19. [Java → .NET Cheat Sheet](#19-java--net-cheat-sheet)
20. [Resources](#20-resources)

---

## 1. What is .NET?

**.NET** is a free, open-source, cross-platform development framework built and maintained by Microsoft. It supports building:

| App Type | Examples |
|---|---|
| Web applications & APIs | ASP.NET Core, Minimal APIs |
| Desktop applications | WPF, WinForms, MAUI |
| Mobile applications | .NET MAUI (iOS & Android) |
| Console tools | CLI utilities, scripts |
| Cloud & microservices | Azure Functions, containers |
| Games | Unity (uses C#) |

> 🔗 [dotnet.microsoft.com](https://dotnet.microsoft.com)

---

## 2. What is C#?

**C#** (pronounced *C-Sharp*) is a strongly typed, object-oriented programming language developed by Microsoft. It runs on the .NET platform.

If you know Java or TypeScript, you'll feel at home quickly. Key traits:

- Type-safe and compiled
- Supports OOP, functional, and async patterns
- Null safety improvements (C# 8+)
- Top-level statements (C# 9+) — write less boilerplate
- Records and pattern matching (C# 9/10+)

---

## 3. .NET Architecture

```
Your C# Code
      │
      ▼
  Roslyn Compiler
      │
      ▼
  Intermediate Language (IL / CIL)
      │
      ▼
  CLR — Common Language Runtime
  (JIT compilation, GC, type safety)
      │
      ▼
  Operating System (Windows / macOS / Linux)
```

| Component | Role |
|---|---|
| **CLR** | Executes .NET apps (JIT compile, garbage collection) |
| **SDK** | Tools to build, compile, test, publish apps |
| **Runtime** | Minimal layer to *run* already-built apps |
| **ASP.NET Core** | Web and API framework |
| **NuGet** | Package and dependency manager |

---

## 4. Installing the .NET SDK

> **SDK vs Runtime:**
> - Install the **SDK** if you're writing or building code.
> - Install the **Runtime** only on servers where you *run* pre-built apps.

Always download the latest **LTS (Long-Term Support)** release for production use.

### Windows

1. Visit [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Download the `.NET SDK` `.exe` installer
3. Run the installer and follow the prompts
4. Open a new Command Prompt and verify:

```cmd
dotnet --version
```

> 💡 The installer automatically adds `dotnet` to your PATH.

---

### macOS

**Option A — Official Installer (recommended)**

Download from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download):
- **Apple Silicon (M1/M2/M3):** Choose `Arm64`
- **Intel Mac:** Choose `x64`

**Option B — Homebrew**

```bash
brew install --cask dotnet-sdk
```

Verify:
```bash
dotnet --version
```

---

### Linux (Ubuntu)

```bash
# Step 1: Update package list
sudo apt update

# Step 2: Install the SDK
sudo apt install -y dotnet-sdk-8.0

# Step 3: Verify
dotnet --version
```

> For other distros (Fedora, Debian, Arch, RHEL), see:
> [learn.microsoft.com/dotnet/core/install/linux](https://learn.microsoft.com/dotnet/core/install/linux)

---

## 5. Environment Variables

The installer usually handles this automatically. If `dotnet` isn't found after install, set these manually.

### Windows

1. Search **"Edit the system environment variables"** in Start
2. Click **Environment Variables**
3. Under *System Variables*, add:

| Variable | Value |
|---|---|
| `DOTNET_ROOT` | `C:\Program Files\dotnet` |

4. Edit the `Path` variable and append:
```
C:\Program Files\dotnet
```

5. Verify in a new terminal:
```cmd
echo %DOTNET_ROOT%
dotnet --version
```

---

### macOS / Linux

Edit your shell config (`~/.zshrc` for Zsh, `~/.bashrc` for Bash):

```bash
export DOTNET_ROOT=/usr/local/share/dotnet
export PATH=$PATH:$DOTNET_ROOT
```

Reload:
```bash
source ~/.zshrc   # or source ~/.bashrc
```

---

## 6. Verify Your Installation

Run these after setup:

```bash
# Show installed version
dotnet --version

# Show full SDK and runtime info
dotnet --info

# List all installed SDKs
dotnet --list-sdks

# List all installed runtimes
dotnet --list-runtimes
```

Expected output for `dotnet --version`:
```
8.0.xxx
```

---

## 7. IDEs & Editors

| Tool | Platform | Best For |
|---|---|---|
| **Visual Studio 2022** | Windows | Full-featured enterprise development |
| **Visual Studio Code** | All | Lightweight, great for web/API |
| **JetBrains Rider** | All | Java developers transitioning to .NET |

**Visual Studio 2022**
Download: [visualstudio.microsoft.com](https://visualstudio.microsoft.com)
During install, select workloads:
- ASP.NET and web development
- .NET desktop development
- (Optional) Azure development

**Visual Studio Code**
Download: [code.visualstudio.com](https://code.visualstudio.com)
Install these extensions:
- `C#` (by Microsoft)
- `.NET Install Tool`
- `C# Dev Kit` *(optional, enhanced experience)*

**JetBrains Rider**
Download: [jetbrains.com/rider](https://www.jetbrains.com/rider)
Familiar interface for IntelliJ/Android Studio users.

---

## 8. Your First C# Program

### Step 1 — Create a Console Project

```bash
dotnet new console -n HelloWorld
cd HelloWorld
```

### Step 2 — Look at `Program.cs`

Modern C# (9+) uses *top-level statements* — no class or Main method needed:

```csharp
// Modern style (C# 9+)
Console.WriteLine("Hello, World!");
```

Classic style still works:
```csharp
// Classic style
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

### Step 3 — Run It

```bash
dotnet run
```

Output:
```
Hello, World!
```

---

## 9. Project Structure Explained

```
HelloWorld/
├── Program.cs            ← Your application entry point
├── HelloWorld.csproj     ← Project config (like pom.xml or package.json)
├── obj/                  ← Intermediate build artifacts (auto-generated)
└── bin/                  ← Compiled output (auto-generated)
    └── Debug/
        └── net8.0/
```

### The `.csproj` File

This is your project manifest — it controls the target framework, dependencies, and build settings.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

</Project>
```

| Property | Meaning |
|---|---|
| `OutputType` | `Exe` for apps, omit for libraries |
| `TargetFramework` | Which .NET version to target |
| `Nullable` | Enables null safety checks |
| `ImplicitUsings` | Auto-includes common `using` statements |

---

## 10. Build, Run & Publish

```bash
# Compile the project
dotnet build

# Build + run in one step
dotnet run

# Run with auto-reload on file changes (dev mode)
dotnet watch run

# Clean all build output
dotnet clean

# Run tests
dotnet test

# Publish a release build
dotnet publish -c Release -o ./publish

# Build in Release mode
dotnet build -c Release

# Run on a specific port (for web apps)
dotnet run --urls=http://localhost:8080
```

> **Tip:** Use `dotnet watch run` during development — it automatically restarts your app when you save changes.

---

## 11. Dependency Management with NuGet

NuGet is the .NET equivalent of npm (Node.js) or Maven (Java).

> 🔗 Browse packages at [nuget.org](https://www.nuget.org)

### Add a Package

```bash
dotnet add package Newtonsoft.Json
dotnet add package Serilog
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

### Add a Specific Version

```bash
dotnet add package Newtonsoft.Json --version 13.0.3
```

### Remove a Package

```bash
dotnet remove package Newtonsoft.Json
```

### Restore All Dependencies

```bash
# Useful after cloning a project
dotnet restore
```

### How It Looks in `.csproj`

```xml
<ItemGroup>
  <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
  <PackageReference Include="Serilog" Version="3.1.1" />
</ItemGroup>
```

> 💡 **Transitive dependencies** are resolved automatically — you don't need to manually add every sub-dependency.

---

## 12. CLI Command Reference

| Command | Description |
|---|---|
| `dotnet new <template>` | Create a new project from a template |
| `dotnet build` | Compile the project |
| `dotnet run` | Build and run the project |
| `dotnet watch run` | Run with hot reload |
| `dotnet test` | Run unit tests |
| `dotnet clean` | Remove build artifacts |
| `dotnet restore` | Restore NuGet packages |
| `dotnet publish` | Publish app for deployment |
| `dotnet add package <name>` | Add a NuGet dependency |
| `dotnet remove package <name>` | Remove a NuGet dependency |
| `dotnet --list-sdks` | List installed SDKs |
| `dotnet --info` | Full environment info |

---

## 13. Project Templates

```bash
dotnet new console        # Console application
dotnet new webapi         # REST Web API
dotnet new mvc            # MVC web application
dotnet new blazor         # Blazor web app
dotnet new classlib       # Reusable class library
dotnet new nunit          # NUnit test project
dotnet new xunit          # xUnit test project
dotnet new maui           # Cross-platform mobile app
dotnet new worker         # Background service
dotnet new grpc           # gRPC service
```

List all available templates:
```bash
dotnet new list
```

---

## 14. Debugging

### Visual Studio 2022

- Set **breakpoints** by clicking the gutter next to a line
- Press **F5** to start with debugger
- Use **Watch**, **Locals**, and **Immediate Window** panels
- Step through code with **F10** (Step Over) and **F11** (Step Into)

### VS Code

1. Install the **C#** extension
2. Open your project folder
3. Press **F5** — VS Code generates a `launch.json` automatically
4. Set breakpoints by clicking the gutter

### Logging (recommended for all environments)

```csharp
// Built-in ILogger (ASP.NET Core)
public class MyService
{
    private readonly ILogger<MyService> _logger;

    public MyService(ILogger<MyService> logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        _logger.LogInformation("Starting work at {Time}", DateTime.UtcNow);
    }
}
```

---

## 15. Advanced Concepts

### LINQ — Query Collections

```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

// Filter, transform, and aggregate
var evenSquares = numbers
    .Where(n => n % 2 == 0)
    .Select(n => n * n)
    .ToList();
// Result: [4, 16, 36]
```

---

### Async / Await

```csharp
using System.Net.Http;

var client = new HttpClient();

// Non-blocking HTTP call
var response = await client.GetStringAsync("https://api.example.com/data");
Console.WriteLine(response);
```

> **Rule of thumb:** If a method is async, its callers should be async too ("async all the way up").

---

### Dependency Injection (ASP.NET Core)

```csharp
// Program.cs — Register services
builder.Services.AddScoped<IEmailService, SmtpEmailService>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

// Your class — Inject via constructor
public class OrderController : ControllerBase
{
    private readonly IEmailService _email;

    public OrderController(IEmailService email)
    {
        _email = email;
    }
}
```

---

### Records (C# 9+)

```csharp
// Immutable data objects — great for DTOs and domain models
public record Person(string FirstName, string LastName);

var alice = new Person("Alice", "Smith");
var bob = alice with { FirstName = "Bob" }; // Non-destructive mutation
```

---

### Pattern Matching (C# 8+)

```csharp
object shape = new Circle(radius: 5);

var area = shape switch
{
    Circle c   => Math.PI * c.Radius * c.Radius,
    Rectangle r => r.Width * r.Height,
    _          => throw new ArgumentException("Unknown shape")
};
```

---

### Entity Framework Core (ORM)

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

```csharp
public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder opts)
        => opts.UseSqlServer("your-connection-string");
}

// Query
var expensive = await context.Products
    .Where(p => p.Price > 100)
    .OrderBy(p => p.Name)
    .ToListAsync();
```

---

### Minimal APIs (ASP.NET Core 6+)

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => "Hello, World!");

app.MapGet("/users/{id}", async (int id, AppDbContext db) =>
    await db.Users.FindAsync(id) is User user
        ? Results.Ok(user)
        : Results.NotFound());

app.Run();
```

---

### Docker Support

```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "YourApp.dll"]
```

Build and run:
```bash
docker build -t myapp .
docker run -p 8080:80 myapp
```

---

## 16. iOS & Mobile with .NET MAUI

**.NET MAUI** (Multi-platform App UI) lets you write one C# codebase and deploy to iOS, Android, macOS, and Windows.

**Requirements:**
- macOS machine
- Xcode installed (from the [Mac App Store](https://developer.apple.com/xcode/))
- Apple Developer account (for device deployment)

### Setup

```bash
# Install the MAUI workload
dotnet workload install maui

# Create a new MAUI app
dotnet new maui -n MyMobileApp
cd MyMobileApp

# Build and run
dotnet build
```

> 🔗 [MAUI Documentation](https://learn.microsoft.com/dotnet/maui/)

---

## 17. Troubleshooting

### `dotnet: command not found`

**Windows:** Verify that `C:\Program Files\dotnet` is in your system `PATH`.

**macOS/Linux:**
```bash
echo $PATH
# Should contain the dotnet install directory

# Fix: add to shell config
export PATH=$PATH:/usr/local/share/dotnet
source ~/.zshrc
```

---

### SDK Not Detected

```bash
dotnet --list-sdks
# If empty, reinstall the SDK from dotnet.microsoft.com
```

---

### Port Already in Use

```bash
dotnet run --urls=http://localhost:8081
```

Or update `launchSettings.json` in the `Properties/` folder.

---

### Package Restore Fails

```bash
dotnet nuget locals all --clear   # Clear local NuGet cache
dotnet restore
```

---

### SSL Certificate Error (HTTPS dev)

```bash
dotnet dev-certs https --trust
```

---

## 18. Best Practices

**Do:**
- Use the latest LTS SDK version for new projects
- Enable nullable reference types (`<Nullable>enable</Nullable>`)
- Use `async/await` consistently — never `.Result` or `.Wait()` on async methods
- Use dependency injection; avoid `static` service locators
- Write unit tests alongside your code
- Use `ILogger<T>` for structured logging
- Store secrets in environment variables or Secret Manager, never in source code
- Use `records` for immutable data transfer objects

**Avoid:**
- Hardcoded connection strings or API keys in code
- Catching generic `Exception` without re-throwing or logging
- Overly large classes or methods (Single Responsibility Principle)
- Blocking async code with `.GetAwaiter().GetResult()`
- Ignoring `IDisposable` — always use `using` statements

---

## 19. Java → .NET Cheat Sheet

| Java Concept | .NET Equivalent |
|---|---|
| JVM | CLR (Common Language Runtime) |
| Maven / Gradle | NuGet + `.csproj` |
| `pom.xml` / `build.gradle` | `.csproj` |
| `.jar` | `.dll` |
| Spring Boot | ASP.NET Core |
| Hibernate | Entity Framework Core |
| JUnit | xUnit / NUnit |
| `System.out.println` | `Console.WriteLine` |
| `ArrayList<T>` | `List<T>` |
| `HashMap<K,V>` | `Dictionary<K,V>` |
| Interface | Interface (same concept) |
| Abstract class | Abstract class (same) |
| `Optional<T>` | Nullable reference types / `?` |
| `CompletableFuture` | `Task<T>` / `async-await` |
| Lombok `@Data` | C# `record` |

---

## 20. Resources

| Resource | Link |
|---|---|
| Official .NET Docs | [learn.microsoft.com/dotnet](https://learn.microsoft.com/dotnet) |
| C# Language Reference | [learn.microsoft.com/dotnet/csharp](https://learn.microsoft.com/dotnet/csharp) |
| ASP.NET Core Docs | [learn.microsoft.com/aspnet/core](https://learn.microsoft.com/aspnet/core) |
| NuGet Package Search | [nuget.org](https://www.nuget.org) |
| .NET GitHub Samples | [github.com/dotnet/samples](https://github.com/dotnet/samples) |
| C# Interactive Playground | [dotnetfiddle.net](https://dotnetfiddle.net) |
| .NET MAUI | [learn.microsoft.com/dotnet/maui](https://learn.microsoft.com/dotnet/maui) |

---

## Quick-Start Workflow

```bash
# 1. Verify SDK is installed
dotnet --version

# 2. Create a new console project
dotnet new console -n MyApp

# 3. Navigate into the project
cd MyApp

# 4. Add a NuGet package (optional)
dotnet add package Newtonsoft.Json

# 5. Edit Program.cs in your IDE

# 6. Run the app
dotnet run

# 7. Run tests (if you have a test project)
dotnet test

# 8. Publish for deployment
dotnet publish -c Release -o ./publish
```

---

*You're ready to build anything — from CLI tools and REST APIs to mobile apps and microservices. Happy coding!*