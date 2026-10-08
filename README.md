# Sim Timing Tools · 公开下载

此分支仅提供试用包和操作说明。

组合试用包约 1.05 MB，包含轻量使用工具及小体积授权管理工具，设备需要已有 .NET Framework 4.8 和 WebView2 Runtime。

公开下载地址：

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-LocalTrial-Light-and-Admin-v0.2.zip
```

完整解压后先阅读“详细操作步骤.md”；交给其他 AI 协助配置时提供“交给AI的任务说明.md”。管理工具初始化需要管理员单独保管的导入密码，密码不在本仓库。密码保护的密钥导入文件不可代替密码本身。

本机授权无需网络共享目录。使用工具启动时和每 24 小时检查授权，未授权账号不能打开。核心计算仍为 JavaScript，尚未完成 C# 核心迁移。

完整版和标准版暂未完成，此分支不提供缺少组件的成品。


## 精简使用包 v0.3

下载地址：

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.3.zip
```

需要 Windows 10 x64、.NET Framework 4.8 和 WebView2 Runtime；压缩后约 0.85 MB。
此使用包不含使用说明或授权管理工具。原有授权名单、管理密码和管理工具可继续使用。
授权文件路径可在底部“授权路径 → 设置授权文件路径”直接粘贴或选取，也可直接粘贴到“授权路径.txt”，无需转义反斜杠。
旧版 settings.json 的 licensePath 仍可读取；非空的“授权路径.txt”优先。
启用每个显示器的高 DPI 模式；波形按当前像素密度绘制，切换不同缩放比例的屏幕时保留缩放范围与游标。
包含当前网页版功能。已通过编译、授权与路径测试，以及网页像素密度切换检查；Windows 实机清晰度需实际试用确认。
