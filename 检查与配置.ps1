param(
    [string]$LicensePath = '',
    [switch]$CheckOnly,
    [switch]$OpenManager,
    [switch]$StartTool
)
$ErrorActionPreference = 'Stop'
$trialRoot = $PSScriptRoot
$toolFolder = Join-Path $trialRoot '使用工具'
$managerFolder = Join-Path $trialRoot '授权管理工具（仅自己保留）'
if (-not [Environment]::Is64BitOperatingSystem) { throw '此包仅支持 Windows 64 位。' }
$release = 0
try { $release = [int](Get-ItemPropertyValue 'HKLM:\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full' -Name Release) } catch { }
$webViewEntries = @(
    foreach ($registryRoot in @('HKCU:\SOFTWARE\Microsoft\EdgeUpdate\Clients','HKLM:\SOFTWARE\Microsoft\EdgeUpdate\Clients','HKLM:\SOFTWARE\WOW6432Node\Microsoft\EdgeUpdate\Clients')) {
        if (Test-Path $registryRoot) {
            foreach ($entry in Get-ChildItem $registryRoot -ErrorAction SilentlyContinue) {
                try {
                    $value = Get-ItemProperty $entry.PSPath -ErrorAction Stop
                    if ($value.name -match 'WebView2' -and $value.pv -and $value.pv -ne '0.0.0.0') {
                        [pscustomobject]@{ Name=$value.name; Version=$value.pv; Registry=$entry.Name }
                    }
                } catch { }
            }
        }
    }
)
$identity = [System.Security.Principal.WindowsIdentity]::GetCurrent()
try { $account = $identity.Name } finally { $identity.Dispose() }
[pscustomobject]@{
    Windows64Bit = [Environment]::Is64BitOperatingSystem
    FrameworkRelease = $release
    Framework48OrLater = ($release -ge 528040)
    WindowsAccount = $account
    WebView2RegistryEntries = $webViewEntries
    ToolFolder = $toolFolder
} | ConvertTo-Json -Depth 4 | Write-Output
if ($CheckOnly) { return }
if ($release -lt 528040) { throw '未检测到 .NET Framework 4.8。已停止配置；请向管理员说明缺少的组件。' }
if (-not (Test-Path (Join-Path $toolFolder '启动工具.exe'))) { throw '找不到使用工具启动文件，请完整解压组合包。' }
if (-not (Test-Path (Join-Path $managerFolder '启动授权管理.exe'))) { throw '找不到授权管理启动文件，请完整解压组合包。' }
if ([string]::IsNullOrWhiteSpace($LicensePath)) { $LicensePath = Join-Path $trialRoot '本机授权\licenses.json' }
$LicensePath = [IO.Path]::GetFullPath($LicensePath)
$parent = Split-Path -Parent $LicensePath
New-Item -ItemType Directory -Path $parent -Force | Out-Null
$configPath = Join-Path $toolFolder 'settings.json'
$config = Get-Content -LiteralPath $configPath -Raw -Encoding UTF8 | ConvertFrom-Json
$config.licensePath = $LicensePath.Replace('\','/')
$config | ConvertTo-Json -Depth 4 | Set-Content -LiteralPath $configPath -Encoding UTF8
Write-Output ('已配置授权名单路径：' + $LicensePath)
Write-Output '名单必须由管理工具签发；脚本不会创建空名单或处理密码。'
if ($webViewEntries.Count -eq 0) { Write-Warning '未检测到 WebView2 注册信息，使用工具可能无法启动；最终以实际启动为准。' }
if ($OpenManager) {
    Start-Process -FilePath (Join-Path $managerFolder '启动授权管理.exe') -WorkingDirectory $managerFolder -ArgumentList ('--license-path "' + $LicensePath + '"')
    Write-Output '已打开授权管理工具。请在窗口中输入密码，添加当前账号并保存。'
}
if ($StartTool) {
    if (-not (Test-Path -LiteralPath $LicensePath -PathType Leaf)) { throw '名单尚未生成，请先打开管理工具并保存授权。' }
    Start-Process -FilePath (Join-Path $toolFolder '启动工具.exe') -WorkingDirectory $toolFolder
}
