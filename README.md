# Sim Timing Tools · 公开下载

## Wuhao Studio · 授权管理 v0.5.4（简洁目录）

参照Sim Timing，完整解压到新文件夹后，外层只有“启动授权管理.exe”和“程序及运行组件”。双击外层启动程序，主程序、DLL、config、网页资源全部保存在组件文件夹中；两项需放在同一目录，不要单独复制启动器。保留v0.5.3密钥设置和签发流程，沿用原本机管理数据及密钥位置。Windows x64 / .NET4.8 / WebView2。构建及实际解压包的桥接/4K回归通过，Windows双击启动待实机确认。原包保留。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/WuhaoStudio-LicenseManager-net48-x64-v0.5.4.zip
```

SHA256：`ec37dc91f800ba2223680920cc9223f2cc0cbbf7d0a5ced0b8561b88522ee628`

## Wuhao Studio · 授权管理 v0.5.3（密钥设置 / 签发流程优化）

页面下方新增“签发密钥设置”：选择原加密密钥，原生密码框验证成功后只记住文件位置。日常签发、补签和加密备份只输入密码，不反复选择文件。支持重新选择原密钥文件、状态刷新和默认折叠的位置。错误选择授权名单、密码或损坏、公钥不匹配及不可读取分别提示；配置失败保留原设置。未配置或文件丢失时阻止签发。密码和私钥不进入网页、包或管理备份，不生成新密钥，不改变原客户端公钥/签名协议。空目录直接首次签发，旧文件继续检查原指纹。

Windows x64 / .NET4.8 / WebView2，完整解压运行 WuhaoLicenseManager.exe。保留高DPI与组织/产品操作。98项临时密钥检查及桌面桥接/4K布局通过，实际Windows原生对话框及原生产密钥仍待管理机验收。原包保留。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/WuhaoStudio-LicenseManager-net48-x64-v0.5.3.zip
```

SHA256：`76cab25289f52017695aa506e56b7e375ca797bbf2424fbc39f9d60f0795cbe0`

## Wuhao Studio · 授权管理 v0.5.2（历史账号 / 账号改名）

添加账号可选择已保存/历史账号；现有账号直接编辑原记录，历史名称只填名称、不自动恢复权限。账号可改名，同步原组织产品记录并保留到期/状态/隐藏版本；重名或其他组织占用时拒绝覆盖，签发后对客户端生效。已导入名单/本机账号自动加入历史，旧工具中尚未导入的名单需先验签导入。保留v0.5.1高DPI适配；本次未调整密钥选择流程。Windows x64 / .NET4.8 / WebView2，完整解压后运行 WuhaoLicenseManager.exe。Windows实机仍待验收。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/WuhaoStudio-LicenseManager-net48-x64-v0.5.2.zip
```

SHA256：`06feb6339028cd939c1bdf467e1fdaba8309b54e23c8aa8e8b96968472b8ca9e`

## Wuhao Studio · 授权管理 v0.5.1（4K 高 DPI 修复）

修复桌面端缺少高DPI支持的问题：PerMonitorV2、主窗口/密码框随Windows缩放、启动窗口不超出当前屏幕工作区。保留原签发流程和名单格式。Windows x64，.NET Framework 4.8 + WebView2，完整解压运行 WuhaoLicenseManager.exe。4K多比例页面布局检查通过，实际Windows清晰度和跨屏切换待机器验收。旧包保留。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/WuhaoStudio-LicenseManager-net48-x64-v0.5.1.zip
```

SHA256：`dbe29aa09125535e4a300028274a7dc3e1b848dbde1204193efc275a67c36884`

## Wuhao Studio · 授权管理 v0.5.0（2026-11-12）

Windows x64，.NET Framework 4.8 + WebView2。完整解压后运行 `WuhaoLicenseManager.exe`。组织共用路径、账号产品复选框、全部账号、旧授权名单验签导入和管理备份；使用原加密密钥和密码，包内无密钥、密码、账号数据或测试后门。原 Timing 签发格式和公钥保持兼容，旧包保留。Windows实机启动、原加密密钥及共享盘权限待管理机验收。

```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/WuhaoStudio-LicenseManager-net48-x64-v0.5.0.zip
```

SHA256：`e2432708e0cc4f528a49a78779d61673d6159ec97429b9c6df1db9b02348c1c3`

## 桌面版 v0.6.3（2026-11-10）

同步最新 HTML 功能，连接联动、派生 Data、像素跨帧保持和 CKH 步进核心迁入受保护 C#；没有增加 V8/ICU。约1.43MB。原授权、公钥与配置方式兼容。单独完整解压，沿用自己的 settings.json，从顶层启动工具.exe 打开；不使用旧组件覆盖新包。Windows实机交互待验收。

包名：SimTimingTools-Light-net48-v0.6.3-NativeReview.zip
SHA256：`7aa66f960fc539b864fcc7877d638f63a94c4d07bc2ad4705cefe658cf93bbba`


仅保留最新精简版、上一版对照及最新授权管理工具。设备需要 .NET Framework 4.8 与 WebView2。原授权密钥、密码和名单兼容。

## 最新精简版 v0.4.4-Priority
```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.4.4-Priority.zip
```

## 上一版对照 v0.4.3-Auth
```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Light-net48-v0.4.3-Auth.zip
```

## 授权管理工具 v0.4.1
从原已验证组合包直接提取，所有文件内容保持原样；不包含私钥或密码。
```text
https://raw.githubusercontent.com/yoyo-mical/mycode/sim-timing-downloads/SimTimingTools-Admin-net48-v0.4.1.zip
```

完整解压使用包，保留原 settings.json 配置后运行启动工具.exe。Windows实际交互待试用。旧包和WebView2分卷已从当前下载目录移除，Git历史未重写。


## v0.4.9 UIReview（界面确认版）

新增电性评估界面、三套主题与图标头部；保留原授权和原生波形核心。Windows实际布局待用户确认。

下载：SimTimingTools-Light-net48-v0.4.9-UIReview.zip
