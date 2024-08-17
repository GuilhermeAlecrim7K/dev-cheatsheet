# Package Versions

[Source](https://learn.microsoft.com/en-us/training/modules/dotnet-dependencies/4-dependency-management)

## Configure the project file for update

When you're adding one or more dependencies, think about configuring your project file so that you get predictable behavior when you restore, build, or run your project. You can communicate the approach that you want to take for a package. NuGet has the concepts of version ranges and floating versions.

Let's first talk about version ranges. This is special notation that's used for specifying specific version ranges that you want to have resolved.

|Notation | Applied rule  | Description                                          |
|---------|---------------|------------------------------------------------------|
|1.0      | x >= 1.0      | Minimum version, inclusive                           |
|(1.0,)   | x > 1.0       | Minimum version, exclusive                           |
|[1.0]    | x == 1.0      | Exact version match                                  |
|(,1.0]   | x ≤ 1.0       | Maximum version, inclusive                           |
|(,1.0)   | x < 1.0       | Maximum version, exclusive                           |
|[1.0,2.0]| 1.0 ≤ x ≤ 2.0 | Exact range, inclusive                               |
|(1.0,2.0)| 1.0 < x < 2.0 | Exact range, exclusive                               |
|[1.0,2.0)| 1.0 ≤ x < 2.0 | Mixed inclusive minimum and exclusive maximum version|
|(1.0)    | invalid       | invalid                                              |

NuGet also supports using a floating version notation for major, minor, patch, and pre-release suffix parts of the number. This notation is an asterisk (*). For example, the version specification 6.0.* says "use the latest 6.0.x version." In another example, 4.* means "use the latest 4.x version." Using a floating version reduces changes to the project file while keeping up to date with the latest version of a dependency.

Here are some examples that can configure for major, minor, or patch version:

```XML
<!-- Accepts any version 6.1 and later. -->
<PackageReference Include="ExamplePackage" Version="6.1" />

<!-- Accepts any 6.x.y version. -->
<PackageReference Include="ExamplePackage" Version="6.*" />
<PackageReference Include="ExamplePackage" Version="[6,7)" />

<!-- Accepts any later version, but not including 4.1.3. Could be
     used to guarantee a dependency with a specific bug fix. -->
<PackageReference Include="ExamplePackage" Version="(4.1.3,)" />

<!-- Accepts any version earlier than 5.x, which might be used to prevent pulling in a later
     version of a dependency that changed its interface. However, we don't recommend this form because determining the earliest version can be difficult. -->
<PackageReference Include="ExamplePackage" Version="(,5.0)" />

<!-- Accepts any 1.x or 2.x version, but not 0.x or 3.x and later. -->
<PackageReference Include="ExamplePackage" Version="[1,3)" />

<!-- Accepts 1.3.2 up to 1.4.x, but not 1.5 and later. -->
<PackageReference Include="ExamplePackage" Version="[1.3.2,1.5)" />
```