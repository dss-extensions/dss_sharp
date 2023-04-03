[![Build](https://github.com/dss-extensions/dss_sharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/dss-extensions/dss_sharp/actions/workflows/dotnet.yml)
[![Latest NuGet release](https://img.shields.io/nuget/v/dss_sharp?label=NuGet+release&cacheSeconds=3600)](https://www.nuget.org/packages/dss_sharp/)

*Para uma versão em português 🇧🇷 deste arquivo, veja [README.pt-BR.md](https://github.com/dss-extensions/dss_sharp/blob/master/README.pt-BR.md).*

# DSS Sharp

DSS Sharp is a C#/.NET wrapper library for DSS C-API, which is an open-source, multi-platform, multi-architecture, extended alternative (unofficial, not provided by EPRI) OpenDSS engine, highly compatible with the official OpenDSS COM implementation and more.

DSS Sharp tries to mimic the organization of the official OpenDSS COM interfaces, plus several extensions (new properties and methods, and whole new classes). If you find conflicting behavior, feel free to report.

This projects exposes most of the functionality implemented in DSS C-API, including performance benefits, ZIP file support, initial JSON exports, multi-platform (Linux, Windows, macOS) support, including Intel x86/x64 and ARM architectures. Contrary to the official implementation, DSS Sharp supports multiple OpenDSS instances ([`dss_sharp.DSS.NewContext()`](https://dss-extensions.org/dss_sharp/html/d0e4d400-3bd9-1244-3cac-8f1234cbad9f.htm)), effectively enabling user-controlled multi-threading applications. Most of the official [parallel-machine](https://dss-extensions.org/dss_sharp/html/f3440753-3e74-bdb2-81c6-9052f8742d7e.htm) functions are also available.

For a general introduction visit https://dss-extensions.org and follow the development of the general documentation at https://github.com/dss-extensions/dss-extensions

<p align="center">
    <img alt="Overview of related repositories" src="https://raw.githubusercontent.com/dss-extensions/dss_capi/master/docs/images/repomap.png" width=600>
</p>

If you are looking for the bindings to other languages:

- [DSS C-API library](http://github.com/dss-extensions/dss_capi/): the base library that exposes a modified version of EPRI's OpenDSS through a more traditional C interface, built with the open-source Free Pascal compiler instead of Delphi. As of 2022, this base library includes several extensive changes, while retaining very good compatibility.
- [dss.hpp](https://dss-extensions.org/dss_capi/): header-only library for C++, hosted within DSS C-API (`include/` directory). Allows using DSS C-API more comfortably from C++, abstract memory management and low-level details such as API conventions of the DSS C-API library.
- [DSS-Python](http://github.com/dss-extensions/dss_python/) is a multi-platform Python module (Windows, Linux, macOS) very compatible with the original COM DLL. See also [OpenDSSDirect.py](http://github.com/dss-extensions/OpenDSSDirect.py/) if you don't need COM compatibility, or just would like to check its extra functionalities (you can mix DSS-Python and OpenDSSDirect.py). DSS-Python includes preliminary plotting capabilities.
[`opendssdirect.utils`](https://dss-extensions.org/OpenDSSDirect.py/opendssdirect.html#module-opendssdirect.utils) to generate some DataFrames.
- [OpenDSSDirect.jl](http://github.com/dss-extensions/OpenDSSDirect.jl/): a Julia module, created by Tom Short (@tshort), recently migrated with the help of Dheepak Krishnamurthy (@kdheepak) to DSS C-API instead of the DDLL.
- [DSS_MATLAB](http://github.com/dss-extensions/dss_matlab/): presents multi-platform integration (Windows, Linux, macOS) with DSS C-API and is also very compatible with the COM classes.

# Documentation

We will grow general documentation at [https://github.com/dss-extensions/dss-extensions](https://github.com/dss-extensions/dss-extensions). Several notes and a FAQ are already available there.

Currently, users can rely on the official OpenDSS COM documentation (as seen in the official installation and from the [SVN repo](https://sourceforge.net/p/electricdss/code/HEAD/tree/trunk/Version8/Distrib/Doc/)). We provide C#/.NET class library docs at https://dss-extensions.org/dss_sharp/

## At a glance

If you are new to C# or have not use it a few years, it's recommended to check updated material on the current state of .NET and best practices.

If you are new to OpenDSS in general, there are two main aspects you need to study:

- The DSS language, which is used to create and edit the components of the circuits, and also run commands to the DSS engine.
- The APIs, mostly notably the class organization and logic sequences of the COM API. These are used to further automate the DSS engine, extract data and integrate to third party software. The current APIs all follow the concept of "active object" that may be new for many users.
    - The official COM DLL is available only for Microsoft Windows ([COM is a Microsoft technology](https://en.wikipedia.org/wiki/Component_Object_Model)), while DSS Sharp tries to reproduce the same API without depending on specific platforms — we can use Windows, Linux, or macOS, even on ARM processors.

The official OpenDSS version from EPRI contains lots of material for both topics and, ignoring the whole installation and registering related to COM, are also applicable to DSS Sharp and other DSS Extensions.

You can learn the basics using the official version and migrate to DSS Sharp when required or when you are interested in the extras from DSS Extensions.

### Installing

There multiple ways, we recommend using NuGet.

If you are using recent versions of Microsoft Visual Studio, you [install the package using NuGet](https://www.nuget.org/packages/dss_sharp/). 

If you're using the SDK style .csproj, you can add a reference like (remember to adjust the version if required):

```xml
    <ItemGroup>
    <PackageReference Include="dss_sharp" Version="0.13.*" />
    </ItemGroup>
```

Finally, if you wish to clone the repository and customize the library code instead, remember to manually download the required DLLs, either using the `scripts/download_native_libs.sh`, or by visiting [the DSS C-API releases](https://github.com/dss-extensions/dss_capi/releases) page.

### Minimal usage

After installing and/or adding the reference to `dss_sharp` in your project, you can test with a circuit.

Assuming you have OpenDSS installed at `C:\Program Files`, this should work:

```cs
using dss_sharp;

//...

var dss = new DSS();
dss.Start(0);
dss.Text.Command = @"redirect 'C:\Program Files\OpenDSS\IEEETestCases\13Bus\IEEE13Nodeckt.dss'";
var voltageMags = dss.ActiveCircuit.AllBusVmag;
```

You can also download our repository [electricdss-tst](https://github.com/dss-extensions/electricdss-tst) to obtain the test/reference circuits and more already adjusted for multi-platform usage (the original files are distributed in the official OpenDSS installer).

### More

A simple, but almost step-by-step, sample is available here: [WinFormsAppSample](https://github.com/dss-extensions/dss_sharp/tree/master/examples/WinFormsAppSample)