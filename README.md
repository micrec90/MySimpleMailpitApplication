# MySimpleMailpitApplication
A simple .NET application demonstrating how to send emails using Mailpit as a local SMTP testing server.

## 📦 Prerequisites
### ✅ 1. Mailpit

Option A - Using Docker (recommended)
```bash
docker run -p 1025:1025 -p 8025:8025 axllent/mailpit
```
Option B - Download the binary with the appropriate version for your OS from the [official Mailpit releases page](https://github.com/axllent/mailpit/releases).

### ✅ 2. MailKit NuGet Package

Using the .NET CLI
```bash
dotnet add package MailKit
```
Using the Package Manager Console
```bash
Install-Package MailKit
```

## 🔗 Additional Links
[Mailpit Documentation](https://mailpit.axllent.org/)
