# Sim Timing Tools · 公开下载

## 最新：C# 核心精简试用版 v0.4.0

压缩约 0.90 MB，解压约 2.58 MB。需要设备已有 .NET Framework 4.8 与 WebView2。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.4.0.zip
```

完整解压后修改 settings.json 的 licensePath，指向现有授权名单，再运行顶层启动工具.exe。原授权名单和原管理工具仍兼容；本版支持 Beta / Standard，并兼容旧 Basic / Pro 名单。使用包不包含操作说明或授权路径文件。

波形生成核心已静态编译成 C#，不再随包提供原 JavaScript 生成引擎。界面和参数预览代码仍为网页代码；编译后的 .NET 程序仍可能被反编译。106 组算法输出及错误拒绝对照检查、授权与调用接口检查通过；Windows 窗口操作仍待实际试用确认。

以下为历史版本记录。


此分支仅提供试用包和操作说明。

组合试用包约 1.05 MB，包含轻量使用工具及小体积授权管理工具，设备需要已有 .NET Framework 4.8 和 WebView2 Runtime。

公开下载地址：

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-LocalTrial-Light-and-Admin-v0.2.zip
```

完整解压后先阅读“详细操作步骤.md”；交给其他 AI 协助配置时提供“交给AI的任务说明.md”。管理工具初始化需要管理员单独保管的导入密码，密码不在本仓库。密码保护的密钥导入文件不可代替密码本身。

本机授权无需网络共享目录。使用工具启动时和每 24 小时检查授权，未授权账号不能打开。核心计算仍为 JavaScript，尚未完成 C# 核心迁移。

完整版和标准版暂未完成，此分支不提供缺少组件的成品。


## 精简使用包 v0.3.1

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.3.1.zip
```

需要 Windows 10 x64、.NET Framework 4.8 和 WebView2 Runtime；压缩后约 0.85 MB。
不含使用说明、授权路径文本文件或授权管理工具。路径只从 settings.json 的 licensePath 读取；原授权管理工具和授权名单可继续使用。
contact 已改为：请飞书联系 吴浩(hao_wu1) 沟通获取权限。
保留 v0.3 的高 DPI 改进和最新网页版功能。Windows 实机清晰度需实际试用确认。
