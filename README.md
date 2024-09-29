# Maple.MonoGameAssistant

## 项目说明

0.  描述

      -  dotNet9 + AOT + Blazor 写了一个 Unity Game 通用修改器框架
      -  x86
      -  x86_64
        
1.  要求

    -  一个VS2022
    -  一个DotNet9(rc1) SDK 需要安装AOT
    -  Unity编译的X64游戏(MONO&IL2CPP) Demo
          -  [Bloomtown A Different Story Demo](https://github.com/blackmaple/Maple.Bloomtown)
          -  [妖之乡](https://github.com/blackmaple/Maple.Ghostmon)

2.  参考
     
    -  [cheat-engine](https://github.com/cheat-engine/cheat-engine)
    -  [Il2CppDumper](https://github.com/Perfare/Il2CppDumper)
    -  [BepInEx](https://github.com/BepInEx/BepInEx)
    -  [MASA.Blazor](https://github.com/masastack/MASA.Blazor)
     
## NuGet
[NuGet](https://www.nuget.org/profiles/BlackMaple)

## 项目参考
 
  - *项目描述*
      |      projectName                                           |      desc                                                      |   status   |
      |------------------------------------------------------------|----------------------------------------------------------------|------------|            
      |      Maple.MonoGameAssistant.Common                        | 常用帮助类                                                      |    ✔      |
      |      Maple.MonoGameAssistant.Logger                        | 简单的日志实现                                                   |    ✔      |
      |      Maple.MonoGameAssistant.MonoCollector                 | MONOAPI&源生成器所需的公用代码1                                    |    ✔      |
      |      Maple.MonoGameAssistant.MonoCollectorDataV2           | MONOAPI&源生成器所需的公用代码2                                    |    ✔      |
      |      Maple.MonoGameAssistant.MonoCollectorGeneratorV2      | 源生成器-对MONOAPI生产类似元数据转成C#代码                              |    ✔      |
      |      Maple.MonoGameAssistant.Core                          | 利用MONOAPI收集类似元数据的项目 参考了CheatEngine中的实现                        |    ✔      |
      |      Maple.MonoGameAssistant.Model                         | 元数据模型                                                                  |    ✔      |
      |      Maple.MonoGameAssistant.UnityCore                     | 对Unity常用类	                                                      |    ✔      |
      |      Maple.MonoGameAssistant.GameCore                      | GameWebApi项目通信的Http                                             |  ✔ |
      |      Maple.MonoGameAssistant.GameDTO                       | GameWebApi传输模型                                                  |   ✔  |
      |      Maple.MonoGameAssistant.GameShared                    | BlazorUI项目共享 用了MASA的UI                                      |  ✔  |
      |      Maple.MonoGameAssistant.GameSSR                       | SSR调试用                                                              |   ✔  |
      |      Maple.MonoGameAssistant.GameWASM                      | WASM发布用 调试卡成🐕                                                  |   ✔  |
      |      Maple.MonoGameAssistant.WebApi                        | MONOAPI的服务端采用了管道通信(基于HTTP)(参考CE)& GameCheat服务端实现  |   ✔  |
      |      Maple.MonoGameAssistant.GameContext                   | Windows-游戏修改器继承基类                                            |   ✔  |
      |      Maple.MonoGameAssistant.HookTask                      | Windows-HOOK WIN MSG 在主线程上执行自定义代码                          |   ✔  |
      |      Maple.MonoGameAssistant.HotKey                        | Windows-HOOK WIN MSG 按键通知                                            |   ✔  |
      |      Maple.MonoGameAssistant.HotKey.Abstractions           | 消息按键通知接口                                                        |   ✔  |
      |      Maple.MonoGameAssistant.UITask                        | Windows-WIN TIMER 在主线程上执行自定义代码                               |   ✔  |
      |      Maple.MonoGameAssistant.WinApi                        | Windows-WIN32API                                                        |   ✔  |
      |      Maple.MonoGameAssistant.DllProxyStaticLib             | Windows-DllProxy C++的静态库 可以让C# AOT 链接                           |   ✔  | 



  - *备注*
      - **MonoTask 实现一个TaskScheduler (注意:调用MONOAPI的都需要附加到MONO这个操作) 让函数利用Task调度到一个指定的线程 附加并执行代码后退出附加**
      - **HookTask 基于HOOK WIN MSG 调度到主线程上执行自定义函数**
      - **UITask 基于WIN32API SetTimer 调度到主线程上执行自定义函数**

  - *劫持代替项目*
      - [DLLProxy](https://github.com/blackmaple/DLLProxy) 
      - [MelonLoader](https://github.com/LavaGang/MelonLoader)
      - [Maple.MonoGameAssistant.DllProxyStaticLib](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.DllProxyStaticLib)
    
```xml
 <ItemGroup>
      <!--add static lib-->
      <NativeLibrary Include="Lib\Maple.MonoGameAssistant.DllProxyStaticLib.lib" />
</ItemGroup>
```

```C#
 [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall),typeof(CallConvSuppressGCTransition)], EntryPoint = nameof(DllMain))]
 [return: MarshalAs(UnmanagedType.Bool)]
 public static bool DllMain(nint hModule, uint ul_reason_for_call, nint lpReserved)
 {
     return InitDllMain(hModule, ul_reason_for_call, lpReserved);
 }


 [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
 [LibraryImport("*")]
 [return: MarshalAs(UnmanagedType.Bool)]
 public static partial bool InitDllMain(nint hModule, uint ul_reason_for_call, nint lpReserved);
```
    
  - *常用API*
       |  Class                                   |  desc                                                                                            |      code      |
       |  -------------------------------         |  ----------------------------------------------------------------------------------------------  |      ----      |
       |  MonoCollectorMethodAttribute            |      对MONOAPI 提供的元数据查找函数地址 支持自定义查找规则                                        |    `[MonoCollectorMethod(Name_Func_ENCODE_TO_JPG, Search = typeof(Search_ImageConversion))]`      |
       |  MonoCollectorPropertyAttribute          |      对MONOAPI 提供的元数据查找class 成员字段 默认按 字段名字查询 以兼容游戏版本                  |    `[MonoCollectorProperty(PropertyName = "Price")]`      |
       |  MonoCollectorStaticPropertyAttribute    |      对MONOAPI 提供的元数据查找class 静态字段 默认按 字段名字查询 以兼容游戏版本                  |    `[MonoCollectorStaticProperty(PropertyName = "Instance")]`      |

 

***

## 项目更新说明
