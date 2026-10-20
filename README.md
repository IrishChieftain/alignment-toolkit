# Alignment Toolkit

**A lightweight starting point for human-guided AI-assisted software development.**

Alignment explores a practical question:

*Can AI coding assistants work more reliably when requirements, architecture, decisions, and implementation boundaries are preserved alongside the code?*

The Alignment Toolkit provides reusable project templates and repository instructions to help developers experiment with that approach.

It is **not** an application or a complete development framework.

## What's included?

The first template, located in `templates/human-guided-web/`, creates a minimal ASP.NET Core application using .NET 10.

Generated projects include:

- `.github/copilot-instructions.md` — instructions that help GitHub Copilot locate project knowledge.
- `docs/index.md` — entry point to project documentation.
- `docs/requirements.md` — requirements and implementation boundaries.
- `docs/architecture.md` — architectural decisions and constraints.
- `docs/decisions.md` — significant project decisions.
- `docs/changes/` — location for change and verification records.

The documents provide a starting structure. **Developers must define and approve their own requirements before implementation.**

## Getting started

**Requirements:** .NET 10 SDK, Git, and a compatible development environment. The original experiment used Visual Studio 2026 with GitHub Copilot.

On Windows, clone this repository:

```powershell
git clone https://github.com/IrishChieftain/alignment-toolkit.git
cd alignment-toolkit
```

Install the template:

```powershell
dotnet new install .\templates\human-guided-web
```

Generate an application:

```powershell
dotnet new alignment-web -n MyAlignmentApp -o .\sandbox\MyAlignmentApp
```

Build it:

```powershell
dotnet build .\sandbox\MyAlignmentApp\MyAlignmentApp.slnx
```

The `sandbox/` directory is excluded from the Toolkit repository.

A generated application should be maintained as **its own Git repository**, with its code and approved project knowledge versioned together.

## Try the experiment

1. Open your generated application in Visual Studio.
2. Define its actual requirements, exclusions, and architecture in `docs/`.
3. Review and approve those documents.
4. Start a fresh GitHub Copilot conversation in **Ask mode**.
5. Ask Copilot to identify the project's requirements and implementation boundaries using the repository documentation.
6. Check whether Copilot understands the approved requirements before authorizing implementation.
7. Use **Agent mode** to implement a small, approved feature.
8. Review the code and tests, then commit the approved results and relevant documentation.

The central experiment is whether the coding assistant can recover durable project knowledge **without repeatedly copying requirements into its conversation**.

## The wider Alignment workflow

The template provides the repository foundation. The broader experiment also uses:

- **ChatGPT Browser** for planning and technical review.
- **ChatGPT Work Desktop** for maintaining approved Markdown project knowledge and verification evidence.
- **GitHub Copilot** for code implementation and testing.
- **Git** as the versioned source of truth.
- **Obsidian** for reading the same Markdown files and viewing evidence through Bases.

The developer retains responsibility for important decisions, approvals, and commits.

These tools support a workflow; the template does not automatically configure or orchestrate them.

## Current status

The template has been successfully installed, used to generate a .NET 10 application, built with the .NET 10 SDK, and opened in Visual Studio 2026.

Copilot has also successfully located and interpreted the generated Markdown knowledge structure.

The template intentionally does not include application-specific business logic, a database, authentication, a user interface, or an automated verification suite.

For an example of the workflow applied to an actual feature, see **[Alignment Demo](https://github.com/IrishChieftain/alignment-demo)**.

**Alignment remains experimental. Its benefits over simpler AI-assisted development workflows have not yet been established.**
