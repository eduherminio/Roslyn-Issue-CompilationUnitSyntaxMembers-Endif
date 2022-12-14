# roslyn-66019-compilationunitsyntax-endif

Reproduction steps:

`dotnet run`

Expected output:
```
{content of endif-at-the-end.cs}
========================================
{content of endif-not-at-the-end.cs}
```

Actual output:
```
{content of endif-at-the-end.cs} <---- Incomplete, missing #endif
========================================
{content of endif-not-at-the-end.cs} <---- Complete, for comparison purposes
```

```csharp
---> endif-at-the-end.cs:
namespace Endif;

#if DEBUG
public class A1
{

}
#else

public class B1
{

}
========================================
---> endif-not-at-the-end.cs:
namespace Endif;

#if DEBUG
public class A2
{

}
#else

public class B2
{

}

#endif

public class C2
{

}
```
