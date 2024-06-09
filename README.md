# Maple.MonoGameAssistant

## 项目说明

0.  描述

      -  dotNet8 + AOT + Blazor 写了一个 Unity Game 通用修改器框架 只支持WinX64

1.  要求

    -  一个VS2022
    -  一个DotNet8 SDK 需要安装AOT
    -  一个Unity编译的X64游戏

2.  参考
     
    -  [cheat-engine](https://github.com/cheat-engine/cheat-engine)
    -  [Il2CppDumper](https://github.com/Perfare/Il2CppDumper)
    -  [BepInEx](https://github.com/BepInEx/BepInEx)
    -  [MASA.Blazor](https://github.com/masastack/MASA.Blazor)
     

## 项目文件

1.  Common

      ###
      |  project                          |  desc                                                                                            |  status  |
      |  -------------------------------  |  ----------------------------------------------------------------------------------------------  |  ------  |
      |  [Maple.MonoGameAssistant.Common](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.Common)    |  公有辅助类&winapi  | ✔ |
      |  [Maple.MonoGameAssistant.HotKey](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.HotKey)    |  HOOK WIN MSG & 执行自定义消息 | ✔  |
      |  [Maple.MonoGameAssistant.Logger](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.Logger)    |  简单的日志 实现ILogger        |  ✔  |
    
2.  Generator

      ###
      |  project                          |  desc                                                                                            |  status  |
      |  -------------------------------  |  ----------------------------------------------------------------------------------------------  |  ------  |
      |  [Maple.MonoGameAssistant.DllExportTmp](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.DllExportTmp)|  WINHTTP.DLL劫持的实现 依赖源生成器  |  ✔  |
      |  [Maple.MonoGameAssistant.DllHijackData](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.DllHijackData)|  DLL劫持源生成器所需的公用代码  |  ✔  |
      |  [Maple.MonoGameAssistant.DllHijackGenerator](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.DllHijackGenerator)|  DLL劫持源生成器实现  |  ✔  |
      |  [Maple.MonoGameAssistant.MonoCollector](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.MonoCollector)| MONOAPI&源生成器所需的公用代码1 |  ✔  |
      |  [Maple.MonoGameAssistant.MonoCollectorDataV2](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.MonoCollectorDataV2)|   MONOAPI&源生成器所需的公用代码2  |  ✔  |
      |  [Maple.MonoGameAssistant.MonoCollectorGeneratorV2](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.MonoCollectorGeneratorV2)|  源生成器-对MONOAPI生产类似元数据转成C#代码 |  ✔  |

3.  MonoCore

      ###
      |  project                          |  desc                                                                                            |  status  |
      |  -------------------------------  |  ----------------------------------------------------------------------------------------------  |  ------  |
      |  [Maple.MonoGameAssistant.Core](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.Core)  |  利用MONOAPI收集类似元数据的项目 参考了CheatEngine中的实现  |  ✔  |
      |  [Maple.MonoGameAssistant.Model](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.Model])  | 元数据模型  |  ✔  |
      |  [Maple.MonoGameAssistant.UnityCore](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.UnityCore)*注释*  | 对Unity常用类&MONO线程的Task调度&UnityUI主线程的Task调度(Send UserWinMsg)|  ✔  |

      - *注释*
          -  **`MonoTask` 实现一个TaskScheduler (注意:调用MONOAPI的都需要附加到MONO这个操作) 让函数利用Task调度到一个指定的线程 附加并执行代码后退出附加( 主要还是附加不退 直接关闭游戏会卡死 )**
          -  **`UnityTask` 实现一个TaskScheduler (注意:Unity的对象可能需要在UI线程上操作) 让函数利用Task调度到窗口主线程(一般也是UI线程) 利用HOOK WIN MSG 发送了一个UserMsgCode**

4. UI
    -  GameUI

      ###
      |  project                          |  desc                                                                                            |  status  |
      |  -------------------------------  |  ----------------------------------------------------------------------------------------------  |  ------  |
      |  [Maple.MonoGameAssistant.GameCore](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.GameCore)  | GameWebApi项目通信的Http   |  ×  |
      |  [Maple.MonoGameAssistant.GameDTO](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.GameDTO)  |  GameWebApi传输模型  |   ×  |
      |  [Maple.MonoGameAssistant.GameShared](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.GameShared)  |  BlazorUI项目共享 用了MASA的UI  |   ×  |
      |  [Maple.MonoGameAssistant.GameSSR](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.GameSSR)  |  SSR调试用  |   ×  |
      |  [Maple.MonoGameAssistant.GameWASM](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.GameWASM)  |  WASM发布用 调试卡成🐕  |   ×  |

    -  GameWebApi

      ###
      |  project                          |  desc                                                                                            |  status  |
      |  -------------------------------  |  ----------------------------------------------------------------------------------------------  |  ------  |
      |  [Maple.GameContext](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.GameContext)  | GameCheat的基类 具体使用参考: |  ✔  |
      |  [Maple.MonoGameAssistant.WebApi](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.WebApi)  | MONOAPI的服务端采用了管道通信(基于HTTP)(参考CE)& GameCheat服务端实现 |  ✔  |
          
    -  MonoDataUI

      ###
      |  project                          |  desc                                                                                            |  status  |
      |  -------------------------------  |  ----------------------------------------------------------------------------------------------  |  ------  |
      |  [Maple.MonoGameAssistant.UILogic](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.UILogic)  | MONOAPI的客户端采用了管道通信(基于HTTP)(参考CE) |  ✔  |
      |  [Maple.MonoGameAssistant.WinForm](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.WinForm)  | MONOAPI的UI 采用了DEVEXPRESS |  ✔  |

***

## 项目更新说明
