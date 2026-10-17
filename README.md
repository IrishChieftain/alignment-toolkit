# Human-Guided AI Development Toolkit — prototype

This repository is the **shared starter kit**, not an application's project knowledgebase. The source for the first minimal ASP.NET Core/.NET 10 template lives in `templates/human-guided-web/`.

## Try it on Windows with .NET 10 SDK installed

From this toolkit repository root:

```powershell
dotnet new install .\templates\human-guided-web
dotnet new hg-web -n LaptopReturnDemo -o .\sandbox\LaptopReturnDemo
dotnet build .\sandbox\LaptopReturnDemo\LaptopReturnDemo.slnx
```

The `sandbox/` folder is ignored by the toolkit repo. Treat the generated application as **its own separate Git repository** once you approve its starting files.

The `.template.config/template.json` file instructs .NET to replace `StarterApp` with `LaptopReturnDemo` in project names, paths, namespaces, and content.

**Validation:** files and JSON checked, but `dotnet new`/`dotnet build` have not been run in the creation environment because .NET SDK is not installed there. Validate in Visual Studio/Windows before committing or publishing this as a supported template.

**Intentional limits:** no authentication, database, UI framework, tests, complex agent roles, or shared-standards auto-updater yet. The first test is whether Copilot can recover approved Markdown requirements from a generated repo without copying them into chat.
