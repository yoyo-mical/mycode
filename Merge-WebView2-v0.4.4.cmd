@echo off
setlocal
cd /d "%~dp0"
if not exist "SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.001" goto missing
if not exist "SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.002" goto missing
if not exist "SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.003" goto missing
if not exist "SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.004" goto missing
copy /b "SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.001"+"SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.002"+"SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.003"+"SimTimingTools-WebView2-net48-v0.4.4-Priority.zip.004" "SimTimingTools-WebView2-net48-v0.4.4-Priority.zip" >nul
if errorlevel 1 goto failed
powershell -NoProfile -Command "if ((Get-FileHash -Algorithm SHA256 -LiteralPath 'SimTimingTools-WebView2-net48-v0.4.4-Priority.zip').Hash -ne 'e7412e2d8e7c9fb137882c21ea715435e281183a39d0003d88c96cd184fd5c0e') {exit 1}"
if errorlevel 1 goto failed
echo ZIP created and SHA256 verified. Extract the ZIP, restore settings.json, then run the launcher.
pause
exit /b 0
:missing
echo Download all four ZIP parts into this folder first.
pause
exit /b 1
:failed
echo Merge or hash verification failed. Please download the parts again.
pause
exit /b 1
