# Logging and Tracing in .NET Applications

[Source](https://learn.microsoft.com/en-us/training/modules/dotnet-debug/5-logging-and-tracing)

Tracing is a way for you to monitor your application's execution while it's running. You can add tracing and debugging instrumentation to your .NET application when you develop it. You can use that instrumentation while you're developing the application and after you've deployed it.

## Define TRACE and DEBUG constants

By default, when an application is running under debug, the `DEBUG` constant is defined. You can control this b adding a `DefineConstants` entry in the project file in a property group. Here's an example of turning on `TRACE` for both `Debug` and `Release` configurations in addition to `DEBUG` for `Debug` configurations.

```XML
<PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
    <DefineConstants>DEBUG;TRACE</DefineConstants>
</PropertyGroup>
<PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
    <DefineConstants>TRACE</DefineConstants>
</PropertyGroup>
```

When you use `Trace` when not attached to the debugger, you'll need to configure a trace listener such as dotnet-trace.