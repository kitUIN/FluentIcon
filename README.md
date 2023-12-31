<div align="center">

# FluentIcon

### ✨ 使用Windows App SDK 构建的FluentIcon控件 ✨
### ✨ Windows App SDK Fluent Icon Control ✨
</div>

<p align="center">
  <a href="https://github.com/kitUIN/FluentIcon/blob/master/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-green" alt="license">
  </a>
  <a href="https://github.com/kitUIN/FluentIcon/releases">
    <img src="https://img.shields.io/github/v/release/kitUIN/FluentIcon" alt="release">
  </a>
</p> 
<div align="center">
  
![image](https://github.com/kitUIN/FluentIcon/assets/68675068/05c85b8b-44e5-4600-bcda-ca57dab5d66c)
  
</div>

## 介绍📖
图标均来自于[Fluentui-System-Icon](https://github.com/microsoft/fluentui-system-icons)

字体文件[FluentSystemIcons-Regular.ttf](https://github.com/microsoft/fluentui-system-icons/blob/main/fonts/FluentSystemIcons-Regular.ttf) (不必安装字体,`nuget`包中自带)

字体文件[FluentSystemIcons-Filled.ttf](https://github.com/microsoft/fluentui-system-icons/blob/main/fonts/FluentSystemIcons-Filled.ttf) (不必安装字体,`nuget`包中自带)

`json2Symbol.py`文件为`json`转`Symbol`枚举

## 简单使用🛠️

请先安装`nuget`包
- [KitUIN.FluentIcon.WinUI.Regular](https://www.nuget.org/packages/KitUIN.FluentIcon.WinUI.Regular/)
- [KitUIN.FluentIcon.WinUI.Filled](https://www.nuget.org/packages/KitUIN.FluentIcon.WinUI.Filled/)

在`.csproj`中按如下修改
```diff
<ItemGroup>
- <PackageReference Include="kitUIN.FluentIcon.WinUI.Filled" Version="1.2.224.2" />
+ <PackageReference Include="kitUIN.FluentIcon.WinUI.Filled" Version="1.2.224.2" GeneratePathProperty="true" />
- <PackageReference Include="kitUIN.FluentIcon.WinUI.Regular" Version="1.2.224.2" />
+ <PackageReference Include="kitUIN.FluentIcon.WinUI.Regular" Version="1.2.224.2"  GeneratePathProperty="true" />
  <PackageReference Include="Microsoft.WindowsAppSDK" Version="1.4.231008000" />
  <PackageReference Include="Microsoft.Windows.SDK.BuildTools" Version="10.0.22621.756" />
  <PackageReference Include="ShadowViewer.Plugin.Local" Version="1.0.3" />
</ItemGroup>
+ <Target Name="CopyPackageFiles" BeforeTargets="Build">
+   <Copy SourceFiles="$(PkgkitUIN_FluentIcon_WinUI_Regular)\lib\net6.0-windows10.0.19041\kitUIN.FluentIcon.WinUI.Regular\Assets\FluentSystemIcons-Regular.ttf" DestinationFolder="Assets\" />
+   <Copy SourceFiles="$(PkgkitUIN_FluentIcon_WinUI_Filled)\lib\net6.0-windows10.0.19041\kitUIN.FluentIcon.WinUI.Filled\Assets\FluentSystemIcons-Filled.ttf" DestinationFolder="Assets\" />
+ </Target>
```
在需要使用的`Xaml`文件的顶部添加

```
xmlns:icons="using:FluentIcon.WinUI"
```

随后使用

```xml
<icons:FluentRegularIcon Symbol="" />
<icons:FluentFilledIcon Symbol="" />
```

选择你需要的图标,填入`Symbol`中

## 如何选择图标🖼️
安装[Character-Map-UWP](https://www.microsoft.com/store/apps/9wzdncrdxf41?cid=storebadge&ocid=badge),将字体文件拖入,进行挑选
