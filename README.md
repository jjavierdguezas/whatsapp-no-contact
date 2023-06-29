<p align="center">
  <img src="./imgs/appicon.png" width="150" />
</p>

# whatsapp-no-contact

A [.NET MAUI](https://dotnet.microsoft.com/en-us/apps/maui) app to start sending messages to a WhatsApp number without first adding it as a contact

## Disclaimer

I created this app for my own entertainment and to learn about .NET MAUI. I am not responsible for any damage or malfunction

## About the magic:

```csharp
await Launcher.OpenAsync($"https://wa.me/{phoneNumber}"); // 😜
```

## Building the Windows app (without installer)

```shell
msbuild /restore /t:Publish /p:configuration=Release /p:WindowsAppSDKSelfContained=true /p:Platform="Any CPU" /p:WindowsPackageType=None /p:TargetFramework=net7.0-windows10.0.19041.0 /p:PublishSingleFile=true /p:PublishReadyToRun=false
```

<p align="center">
  <img src="./imgs/windows%20dark.png" width="300" />
  <img src="./imgs/windows%20light.png" width="300" />
</p>

## Building the Android apk

```shell
dotnet publish -f net7.0-android -c Release
```

<p align="center">
  <img src="./imgs/android%20dark.jpg" width="300" />
  <img src="./imgs/android%20light.jpg" width="300" />
</p>

## Don't you want to build it?

then just download it from [releases](https://github.com/jjavierdguezas/whatsapp-no-contact/releases)

---
_thanks to ChatGPT for the icon and helping me juggle fixing some obscure issues_
