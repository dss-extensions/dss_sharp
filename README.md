[![Build](https://github.com/dss-extensions/dss_sharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/dss-extensions/dss_sharp/actions/workflows/dotnet.yml)
[![Latest NuGet release](https://img.shields.io/nuget/v/dss_sharp?label=NuGet+release&cacheSeconds=3600)](https://www.nuget.org/packages/dss_sharp/)

# DSS Sharp

DSS Sharp is a C#/.NET wrapper library for DSS C-API, which is an open-source, multiplatform, multiarchitecture, extended alternative (unofficial, not provided by EPRI) OpenDSS engine, highly compatible with the official OpenDSS COM implementation and more.

DSS Sharp tries to mimic the organization of the official OpenDSS COM interfaces, plus several extensions (new properties and methods, and whole new classes). If you find conflicting behavior, feel free to report.

This projects exposes most of the funcionality implemented in DSS C-API, including performance benefits, ZIP file support, initial JSON exports, multi-platform (Linux, Windows, macOS) support, including Intel x86/x64 and ARM architectures. Contrary to the official implementation, DSS Sharp supports multiple OpenDSS instances ([`dss_sharp.DSS.NewContext()`](https://dss-extensions.org/dss_sharp/html/d0e4d400-3bd9-1244-3cac-8f1234cbad9f.htm)), effectively enabling user-controlled multi-threading applications. Most of the official [parallel-machine](https://dss-extensions.org/dss_sharp/html/f3440753-3e74-bdb2-81c6-9052f8742d7e.htm) functions are also available.

For a general introduction visit https://dss-extensions.org and follow the development of the general documentation at https://github.com/dss-extensions/dss-extensions

<p align="center">
    <img alt="Overview of related repositories" src="https://raw.githubusercontent.com/dss-extensions/dss_capi/master/docs/images/repomap.png" width=600>
</p>

If you are looking for the bindings to other languages:

- [DSS C-API library](http://github.com/dss-extensions/dss_capi/): the base library that exposes a modified version of EPRI's OpenDSS through a more traditional C interface, built with the open-source Free Pascal compiler instead of Delphi. As of 2022, this base library includes several extensive changes, while retaining very good compatibility.
- [DSS Python](http://github.com/dss-extensions/dss_python/) is a multi-platform Python module (Windows, Linux, MacOS) very compatible with the original COM DLL. See also [OpenDSSDirect.py](http://github.com/dss-extensions/OpenDSSDirect.py/) if you don't need COM compatibility, or just would like to check its extra functionalities (you can mix DSS Python and OpenDSSDirect.py). DSS Python includes preliminary plotting capabilites.
[`opendssdirect.utils`](https://dss-extensions.org/OpenDSSDirect.py/opendssdirect.html#module-opendssdirect.utils) to generate some DataFrames.
- [OpenDSSDirect.jl](http://github.com/dss-extensions/OpenDSSDirect.jl/): a Julia module, created by Tom Short (@tshort), recently migrated with the help of Dheepak Krishnamurthy (@kdheepak) to DSS C-API instead of the DDLL.
- [DSS MATLAB](http://github.com/dss-extensions/dss_matlab/): presents multi-platform integration (Windows, Linux, MacOS) with DSS C-API and is also very compatible with the COM classes.

# Documentation

We will grow general documentation at https://github.com/dss-extensions/dss-extensions

Currently, users can rely on the official OpenDSS COM documentation (as seen in the official installation and from the [SVN repo](https://sourceforge.net/p/electricdss/code/HEAD/tree/trunk/Version8/Distrib/Doc/)). We provide C#/.NET class library docs at https://dss-extensions.org/dss_sharp/
