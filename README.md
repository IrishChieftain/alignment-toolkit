# Alignment Toolkit — prototype

This repository holds reusable .NET project templates and standing AI development instructions. It is the shared starter kit, not an application's project knowledgebase. The source for the first minimal ASP.NET Core/.NET 10 template lives in `templates/human-guided-web/`.

## Try it on Windows with .NET 10 SDK installed

From this toolkit repository root:

```powershell
dotnet new install .\templates\human-guided-web
dotnet new alignment-web -n LaptopReturnDemo -o .\sandbox\LaptopReturnDemo
dotnet build .\sandbox\LaptopReturnDemo\LaptopReturnDemo.slnx
```

The `sandbox/` folder is ignored by the toolkit repo. Treat the generated application as **its own separate Git repository** once you approve its starting files.

The `.template.config/template.json` file instructs .NET to replace `StarterApp` with `LaptopReturnDemo` in project names, paths, namespaces, and content.

## Verified results

- .NET SDK 10.0.401.
- Successful `dotnet new` template installation.
- Successful creation of `TemplateTest`.
- Successful .NET 10 solution build.
- Visual Studio 2026 recognized the installed template.
- A fresh GitHub Copilot Agent conversation successfully located and interpreted the generated `.github/` and `docs/` Markdown files.

These results do not verify business-rule implementation, which remains intentionally untested, or Git versioning of a generated application.

**Intentional limits:** no authentication, database, UI framework, tests, complex agent roles, or shared-standards auto-updater yet. The first test is whether Copilot can recover approved Markdown requirements from a generated repo without copying them into chat.
