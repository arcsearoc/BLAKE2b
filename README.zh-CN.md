# Blake2bTool —— Windows 哈希与文件时间管理工具

Blake2bTool 是一个轻量的 Windows 窗体应用，用于计算哈希与管理文件时间。支持可配置摘要长度和可选密钥的 BLAKE2b、用于快速校验的 MD5，支持文本/文件输入、Hex/Base64 输出，以及读取/应用文件的创建、修改、访问时间。

## 功能特性

- 哈希：`BLAKE2b`（可配置、可选密钥）与 `MD5`
- 输入：文本或文件，支持拖拽选择文件
- 输出：`Hex`（可选大写）或 `Base64`
- 文件工具：读取并设置文件的`创建`、`修改`、`访问`时间

## 快速开始

- 环境要求：Windows、.NET 9 SDK（用于构建）
- 构建或发布后，运行 `Blake2bTool.exe`

## 构建

```bash
dotnet build Blake2bTool/Blake2bTool.csproj -c Release
```

## 发布

根据分发需求选择以下其中一种方式。

### 框架依赖的单文件（体积极小）

目标机器需安装 .NET 运行时，生成极小的单文件可执行程序。

```bash
dotnet publish Blake2bTool/Blake2bTool.csproj \
  -c Release -r win-x64 \
  -p:PublishSingleFile=true -p:SelfContained=false \
  -p:DebugType=None -p:InvariantGlobalization=true
```

### 自包含单文件（无需运行时，体积较大）

可执行文件内包含运行时，大小显著增加。

```bash
dotnet publish Blake2bTool/Blake2bTool.csproj \
  -c Release -r win-x64 \
  -p:PublishSingleFile=true -p:SelfContained=true \
  -p:DebugType=None -p:EnableCompressionInSingleFile=true \
  -p:InvariantGlobalization=true
```

> 注意：`PublishTrimmed=true` 不支持/不推荐用于 Windows 窗体，启用会触发 `NETSDK1175` 错误。

## 使用说明

- 选择输入源：文本或文件（可浏览/拖拽）
- 选择算法：`BLAKE2b` 或 `MD5`
- 对于 BLAKE2b，可选设置`密钥`与`摘要字节长度`（1–64）
- 选择输出格式：`Hex`（可勾选大写）或 `Base64`
- 点击`计算`获取摘要，可通过`复制`按钮复制结果
- 文件模式下，点击`读取文件时间`加载时间；调整后点击`应用文件时间`写回文件属性

## 说明

- MD5 不适用于安全场景；推荐使用 BLAKE2b
- 仅支持 Windows（WinForms 界面）