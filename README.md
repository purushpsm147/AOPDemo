# AOPDemo

## Overview
AOPDemo is a demonstration project showcasing the use of Aspect-Oriented Programming (AOP) in .NET 8. The project uses `DispatchProxy` to intercept method calls and add additional behavior.

## Project Structure
- **AOPDemo.sln**: The solution file.
- **AOPDemo/AOPDemo.csproj**: The project file targeting .NET 8.
- **AOPDemo/Program.cs**: The entry point of the application.
- **AOPDemo/Services/Students/IStudentService.cs**: The interface for student services.
- **AOPDemo/Services/Students/StudentService.cs**: The implementation of the student service.
- **AOPDemo/StudentServiceDispatch.cs**: The `DispatchProxy` implementation for intercepting method calls.

## Getting Started
1. **Clone the repository**: 

2. **Build the project**:
    Open the solution in Visual Studio and build the project.

3. **Run the application**:
    Set `AOPDemo` as the startup project and run the application.

## Usage
The application demonstrates the following:
- Creating a proxy for `IStudentService` using `StudentServiceDispatch`.
- Intercepting method calls to `AddStudent` and adding custom behavior before the actual method execution.

## Example
```csharp
using AOPDemo.Services.Students;
namespace AOPDemo;
public class Program { 
    static void Main(string[] args) 
    { 
        IStudentService studentService = new StudentService();
        studentService = StudentServiceDispatch<IStudentService>
                .Create(studentService);

        studentService.AddStudent();
}
}
```

In this example, the `AddStudent` method call is intercepted, and a message is logged before the actual method is executed.
