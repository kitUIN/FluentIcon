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

字体文件[FluentSystemIcons-Resizable.ttf](https://github.com/microsoft/fluentui-system-icons/blob/main/fonts/FluentSystemIcons-Resizable.ttf) (不必安装字体,`nuget`包中自带)

`json2Symbol.py`文件为`json`转`Symbol`枚举,`json`文件来自于[FluentSystemIcons-Resizable.json](https://github.com/microsoft/fluentui-system-icons/blob/main/fonts/FluentSystemIcons-Resizable.json)

## 简单使用🛠️
请先安装`nuget`包

在需要使用的`Xaml`文件的顶部添加

```
xmlns:icons="using:FluentIcon"
```

随后使用

```xml
<icons:FluentIcon Symbol="" />
```

选择你需要的图标,填入`Symbol`中

## 如何选择图标🖼️
以下3选1
1. 安装[Character-Map-UWP](https://www.microsoft.com/store/apps/9wzdncrdxf41?cid=storebadge&ocid=badge),将字体文件拖入,进行挑选
2. 运行`Sample`程序,进行挑选
   - 在搜索框用`\u`开头 是使用`Glyph`检索
   ![image](https://github.com/kitUIN/FluentIcon/assets/68675068/59b71d84-1028-4974-9874-04b56829562f)

   - 其他则为使用`名称`检索
   ![image](https://github.com/kitUIN/FluentIcon/assets/68675068/473707b3-dad2-4858-918d-a61bbb744689)

3. Fluent UI System Icons List
   - [View the full list of regular icons](https://github.com/microsoft/fluentui-system-icons/blob/main/icons_regular.md)
   - [View the full list of filled icons](https://github.com/microsoft/fluentui-system-icons/blob/main/icons_filled.md)

