# 主要内容

## 依赖倒置原则和dotnet跨平台的一些实现

1. [依赖倒置原则](https://en.wikipedia.org/wiki/Dependency_inversion_principle)
   1. 概念
      1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
      2. [依赖注入](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
            Dependency injection in .NET is a [first-class citizen](https://en.wikipedia.org/wiki/First-class_citizen), along with configuration, logging, and the options pattern.
      3. [Dependency inversion/Inversion of Control (IoC)](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#dependency-inversion)
      4. [Dependency Injection and Inversion of Control on .Net Core](https://alexalvess.medium.com/dependency-injection-and-inversion-of-control-on-net-core-3136fe98b72)
   2. 实践
      1. 抽象建立
      2. 具体实现
      3. 单元测试mock
2. 跨平台/[云原生-Cloud Native](https://docs.microsoft.com/en-us/dotnet/architecture/cloud-native/definition)
   1. 运行时
      1. 应用
         1. [mono](https://github.com/mono/mono)
         2. [dotnet core](https://github.com/dotnet/runtime)
      2. 操作系统
         1. [docker](https://github.com/dotnet/runtime)
         2. [kubernetes](https://kubernetes.io/)
   2. 具体实践
      1. 服务端
         1. Asp.net Core
         2. docker
      2. Client
         1. XAML
            1. [Xamarin.Forms -->MAUI](https://github.com/dotnet/maui)
            2. [Uno](https://github.com/unoplatform/uno)
            3. [AvaloniaUI](https://github.com/AvaloniaUI/Avalonia)
         2. 其它
            1. [Electron](https://itnext.io/create-desktop-with-electron-react-and-c-86f9765809b7)
            2. [Web Assembly](https://medium.com/young-coder/blazor-desktop-the-electron-for-net-ecdcf5c30027)
            3. [Flutter](https://flutter.cn/desktop)
            4. ...
