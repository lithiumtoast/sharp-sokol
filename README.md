# Sokol\#

A C# wrapper for https://github.com/floooh/sokol.

Includes the C API precisely as it is and a .NET API over the C API for convenience.

[![Build status](https://img.shields.io/appveyor/ci/lithiumtoast/sokol-csharp/master?label=build%2Ftest%20Windows&logo=AppVeyor)](https://ci.appveyor.com/project/LithiumToast/sokol-csharp/branch/master)
[![Build Status](https://img.shields.io/azure-devops/build/lustranks/sokol-csharp/1/master?label=build%2Ftest%20macOS&logo=azure-pipelines)](https://dev.azure.com/lustranks/sokol-csharp/_build/latest?definitionId=1&branchName=master)

## News

- 2019/11/03: .NET Core examples working with Windows.
- 2019/10/25: .NET Core examples working with macOS.
- 2019/10/23: "Unsafe" `sokol_gfx` API fairly well finished.
- 2019/10/15: Initial project creation.

## "Unsafe" API

The [P/Invoke](https://docs.microsoft.com/en-us/dotnet/standard/native-interop/pinvoke) bindings are a pure port of the C headers; they exactly match what is in C, and the naming conventions used in C are maintained.

In .NET, the `unsafe` keyword will most often be necessary for using the C structs and calling the C functions. Also, for practicality, it's recommended to import the static class with all the bindings, structs, and enums like so:

```cs
using static Sokol.sokol_gfx;
```

To learn how to use the C API, check out the [official C samples](https://github.com/floooh/sokol-samples). You can also find the same examples that run in [your browser](https://floooh.github.io/sokol-html5/index.html). The comments in the [`sokol_gfx.h`](https://github.com/floooh/sokol/blob/master/sokol_gfx.h) file are also a good reference.

## "Safe" API

The .NET API is just wrappers over the C API for convenience and ease of use. The `unsafe` keyword is not required. All the "safe" classes/structs have the prefix `Sg`. E.g. `SgBuffer`, `SgShader`, etc. The safe API uses .NET Core v3 and makes use of `System.Numerics` for `Vector2`, `Vector3`, `Matrix4x4`, etc and of `System.Memory` for `Span<T>`, `Memory<T>`, etc. By using these, the code required for the safe API remains small, highly performant, and easy to use without re-inventing the wheel.

To learn how to use the .NET API, check out the [.NET Core v3 samples](https://github.com/lithiumtoast/sokol-csharp/tree/master/src/Samples), which are in sync with the official [C samples](https://github.com/floooh/sokol-samples).

## Supported Platforms

Since `sokol` is a C library, technically, any platform is possible. The following is a table of platforms that are known to work and their supported graphics API backends with `sokol`. If you find that anything is incorrect, I would be more than happy to discuss and change the table in an existing or new [issue](https://github.com/lithiumtoast/sokol-csharp/issues).

Platform|OpenGL 3.x|OpenGLESX/WebGLX|Direct3D11|Direct3D12|Metal|Vulkan
---|---|---|---|---|---|---
Desktop Windows|✅|❌|✅|⭕|❌|⭕
Desktop macOS|❗|❌|❌|❌|✅|⭕
Desktop Linux|✅|❌|❌|❌|❌|⭕
Mobile iOS|❌|❌|❌|❌|✅|⭕
Mobile Android|❌|✅|❌|❌|❌|❓
Browser WebAssembly|❌|✅|❌|❌|❌|❌
Smartwatch watchOS|❌|❌|❌|❌|✅|❌
Microconsole tvOS|❌|❌|❌|❌|✅|❌
Console Nintendo Switch|✅|❌|❌|❌|❌|⭕
Console Xbox One|❌|❌|✅|⭕|❌|❌
Console PlayStation 4|✅|❌|❌|❌|❌|❓

- ⭕ means the graphics API is supported on the platform but not by `sokol`.
- OpenGL is deprecated for macOS; recommended to only use Metal for macOS if hardware supports it. All Apple platforms support Metal and are supported with .NET using [Xamarin](https://dotnet.microsoft.com/apps/xamarin).
- Android is supported with .NET using [Xamarin](https://dotnet.microsoft.com/apps/xamarin).
- As of Q4 2019, WebAssembly is made possible with .NET using [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor). I have not tried to get Sokol working with Blazor yet.
- As of Q4 2019, consoles are made possible with .NET using [BRUTE](http://brute.rocks). However, the tool is not yet released to the general public. Also, SDK licenses are required for each console.

## Contributing

You want to contribute? Awesome! To get started please read the [CONTRIBUTING](CONTRIBUTING) file for details on our code of conduct, and the process for submitting pull requests.

## Versioning

`Sokol#` uses [calendar versioning](https://calver.org) and [semantic versioning](https://semver.org) where appropriate. The version scheme used for dynamic link libraries such as `sokol_gfx` is `YYYY.MM.DD` and the version scheme for `Sokol#` is `MAJOR.MINOR.PATCH.BUILD`. For a complete list of the versions available, see the [tags on this repository](https://github.com/lithiumtoast/sokol-csharp/tags).

## License

`Sokol#` is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Authors

- **Lucas Girouard-Stranks** [@lithiumtoast](https://github.com/lithiumtoast) *Owner*
