# StarterApp — Alignment Starter

This application was generated using the [Alignment Toolkit](https://github.com/IrishChieftain/alignment-toolkit), a lightweight starting point for human-guided AI-assisted software development.

The goal is to preserve requirements, architectural decisions, and implementation boundaries alongside the code so AI assistants can recover project knowledge without repeatedly rebuilding context.

## Getting started

1. Open `docs/index.md` to locate the project's knowledge files.
2. Define the application's requirements, exclusions, acceptance criteria, and architectural constraints.
3. Review and approve that documentation before implementing business features.
4. Keep approved project knowledge in `docs/`, within the **same Git repository as the application code**.
5. Start a fresh GitHub Copilot conversation in Visual Studio, using **Ask mode** to confirm that Copilot can locate and correctly interpret the approved requirements.
6. Use **Agent mode** to implement a small, approved change.
7. Review the resulting code and tests before committing.

Copilot's `.github/copilot-instructions.md` tells it where to find the project's knowledge and when to request clarification.

## Working with Alignment

The broader Alignment experiment separates responsibilities:

- **Developer:** Defines requirements, approves decisions, reviews implementation, and controls Git commits.
- **ChatGPT Browser:** Assists with project planning, technical review, risk identification, and implementation assessment.
- **ChatGPT Work Desktop:** Acts as Librarian, maintaining approved Markdown project knowledge and recording verification evidence.
- **GitHub Copilot:** Implements approved changes and runs relevant tests in Visual Studio.
- **Git:** Versions source code, requirements, decisions, and evidence together.
- **Obsidian:** Opens the application's `docs/` folder directly to display project knowledge and, where configured, verification evidence through Bases.

Obsidian does not require a separate copy of the documentation. The Markdown files in Git remain the source of truth.

The template does not automatically configure or coordinate these tools.

## Build and run

Requires the .NET 10 SDK.

From the generated application's repository root:

```powershell
dotnet build StarterApp.slnx
dotnet run --project StarterApp/StarterApp.csproj
```

## Project boundaries

This is a minimal ASP.NET Core starting application, not a completed business application.

The documentation initially contains placeholders. **Placeholder requirements are not approved requirements.**

The template does not introduce a database, authentication system, user interface, or application-specific business logic.

The application belongs in its **own Git repository**, separate from the Alignment Toolkit. Toolkit updates do not automatically change generated projects.

## See a completed example

Explore [Alignment Demo](https://github.com/IrishChieftain/alignment-demo) for a working .NET 10 example with approved business requirements, GitHub Copilot implementation, automated tests, technical review, and recorded verification evidence.

**Alignment remains experimental. Its benefits over simpler AI-assisted development workflows have not yet been established.**
