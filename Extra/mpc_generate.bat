
@echo off

cd /d %~dp0

"./mpc/mpc.exe" -i "../HoloLensRecorder.csproj" -o "../Assets/Scripts/MessagePackGererated/MessagePackGenerated.cs" 