# MyWebApp

Sample ASP.NET Core minimal API with a solution (`.sln`), project files (`.csproj`), xUnit tests and GitHub Actions CI.

## Run

```bash
dotnet restore
dotnet build
dotnet run --project src/MyWebApp.Web
```

Then open http://localhost:5000 (or `/api/health`, `/api/greet/YourName`).

## Test

```bash
dotnet test
```

## Push to GitHub

```bash
git init -b main
git add .
git commit -m "Initial commit"
gh repo create MyWebApp --private --source=. --remote=origin --push
```
