# Sim Timing Tools · 公开下载

## 授权加强测试版 v0.4.3-Auth

组合包约 1.38 MB，含授权加强后的使用工具和原新版授权管理工具：

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Combined-net48-v0.4.3-Auth.zip
```

仅使用工具约 0.92 MB：

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.4.3-Auth.zip
```

完整解压后，把原 settings.json 放入“使用工具”中替换，再运行启动工具.exe；单独使用包则替换根目录的 settings.json。需要已有 .NET Framework 4.8 和 WebView2。原管理工具、密码、密钥和签名名单继续兼容，无需重新签发。

授权判断增加控制流保护；波形核心必须持有已验证的本机授权凭据，生成、帧计算和时间轴入口均检查，界面的授权标志不足以单独开放核心。缓存增加完整性校验；刷新或关闭时撤销旧凭据。读取授权文件仍为启动时及每24小时，其余操作只检查本机缓存；到期时间也在本机检查。

42个核心/授权方法、227个基本块处理通过覆盖检查，实际保护后的net48 EXE通过106组算法输出/拒绝对照，以及缺失/被修改/停用/过期/账号不符的授权和缓存破坏拒绝检查。参考测量单次本机缓存检查约0.004毫秒（云端net8加载实际net48程序集，含反射调用成本）；Windows启动和实际交互仍待试用。界面、settings、启动器与授权管理工具相比v0.4.2-CF逐字节保持不变，只有使用工具主EXE更新。不含源码、调试文件、混淆映射、私钥、密码或说明文档。

保护提高修改与还原门槛，不能保证客户端代码完全无法破解。旧版本保留供对照。

## 控制流测试版 v0.4.2-CF（与 v0.4.1 分开保留）

组合包约 1.38 MB，包含控制流处理后的使用工具及原 v0.4.1 授权管理工具：

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Combined-net48-v0.4.2-CF.zip
```

仅使用工具约 0.91 MB：

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.4.2-CF.zip
```

完整解压，将原 settings.json 放入“使用工具”中替换，再运行启动工具.exe。设备仍需要已有 .NET Framework 4.8 与 WebView2；原管理密码和名单兼容。

本版在名称/字符串保护之前，对38个适合安全改写的核心方法（187个基本块）实施适度控制流平坦化，未宣称全部方法都处理或无法还原。实际保护后的net48 EXE通过106组算法对照及通信契约/DPI元数据检查。相比v0.4.1包只替换生成工具EXE，界面、配置和授权管理工具逐字节不变。云端交替3轮、每轮20次生成测量：1080行的三轮中位数汇总约为原版1.590秒、测试版1.588秒，差异处于测量波动范围。此为net8加载实际net48程序集的参考数据，不能据此保证Windows速度不变；Windows net48/WebView2启动与操作体验待实机确认。

## 历史组合包：使用工具 + 新版授权管理 v0.4.1

约 1.38 MB，解压约 3.82 MB。设备需要已有 .NET Framework 4.8 和 WebView2。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Combined-net48-v0.4.1.zip
```

1. 完整解压；“使用工具”保持原 v0.4.1 的文件内容，“授权管理工具”为新版总表界面。
2. 使用工具：把原 settings.json 复制到“使用工具”中替换，双击启动工具.exe。
3. 授权管理：打开“授权管理工具/启动授权管理.exe”。原设备沿用原管理密码和本机密钥；新设备需导入自己的加密密钥备份及对应密码，下载包不含密钥或密码。
4. 点击“读取已有名单”选择文件；可选择多个。编辑保存在本机草稿，不直接改变授权文件。选择一份名单并点击“签发当前名单”，确认路径并输入管理密码后生效。
5. 管理登记保存在当前用户本机目录，重开保留多名单总表；草稿可导出和导入。更新目标文件前检查是否已有新内容，过期草稿要求重新读取。
6. 需要分发使用工具时，只提供“使用工具”文件夹，保留管理工具和密钥备份由管理员使用。

版本为 Beta / Standard，原签名名单继续兼容。实际混淆后的 net48 授权工具签发、使用工具识别、草稿读写和冲突检查通过；Windows 实际窗口操作待试用确认。本轮没有增加控制流混淆，使用工具继续采用 v0.4.1 名称混淆与字符串隐藏。

## 单独使用包：C# 核心精简试用版 v0.4.1

压缩约 0.91 MB，解压约 2.64 MB。需要设备已有 .NET Framework 4.8 与 WebView2。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.4.1.zip
```

完整解压后修改 settings.json 的 licensePath，指向现有授权名单，再运行顶层启动工具.exe。原授权名单和原管理工具仍兼容；本版支持 Beta / Standard，并兼容旧 Basic / Pro 名单。使用包不包含操作说明或授权路径文件。

波形生成核心已静态编译成 C#，不再随包提供原 JavaScript 生成引擎。界面和参数预览代码仍为网页代码；本版对 C# 内部名称及字符串进行混淆，提高反编译阅读难度，但仍不能保证完全无法还原。混淆后实际 net48 程序的 106 组算法对照、授权签名与通信检查通过，界面资源和配置文件与 v0.4.0 完全相同；Windows 窗口操作仍待实际试用确认。

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
