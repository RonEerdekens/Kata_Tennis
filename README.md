# Kata_Tennis

This repository contains a simple implementation of a Tennis game scoring system, along with unit tests to verify its functionality.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

## Building the Solution

### Using CLI

1. Open a terminal and navigate to the root directory of the solution.
2. Run the following command to restore the dependencies and build the solution:

```bash
dotnet build

```

### Using Visual Studio

1. Open the solution in Visual Studio.
2. Restore the dependencies by right-clicking on the solution in the Solution Explorer and selecting `Restore NuGet Packages`.
3. Build the solution by pressing `Ctrl+Shift+B` or by selecting `Build > Build Solution` from the menu.

## Running the Application

### Using CLI

1. Navigate to the project directory containing the main application.
2. Run the application using the following command:

```bash
dotnet run
```

### Using Visual Studio

1. Set the startup project by right-clicking on the project in the Solution Explorer and selecting `Set as Startup Project`.
2. Run the application by pressing `F5` or by selecting `Debug > Start Debugging` from the menu.

## Running the Tests

### Using CLI

1. Navigate to the test project directory (e.g., `TennisKata.Tests`).
2. Run the tests using the following command:

```bash
dotnet test
```

### Using Visual Studio

1. Open the Test Explorer by selecting `Test > Test Explorer` from the menu.
2. Run all tests by clicking the `Run All` button in the Test Explorer.

## Project Structure

- `TennisKata/`: Contains the main application code.
- `TennisKata.Tests/`: Contains the unit tests for the application.
