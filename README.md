# Blake2bTool — Windows Hash & File Timestamp Utility

Blake2bTool is a lightweight Windows Forms application for hashing and file timestamp management. It supports BLAKE2b with configurable digest length and optional key, MD5 for quick checks, text/file inputs, Hex/Base64 output, and reading/applying file creation/modified/access times.

## Features

- Hashing: `BLAKE2b` (configurable, optional key) and `MD5`
- Inputs: Text or File, drag-and-drop for files
- Output: `Hex` (uppercase option) or `Base64`
- File tools: Read and set file `Creation`, `Last Write`, and `Last Access` timestamps

## Getting Started

- Requirements: Windows, .NET 9 SDK to build
- Run the app by starting `Blake2bTool.exe` after build or publish

## Build

```bash
dotnet build Blake2bTool/Blake2bTool.csproj -c Release
```

## Publish

Choose one of the following depending on your distribution needs.

### Framework-dependent single file (small size)

Requires .NET runtime installed on the target machine. Produces a very small single executable.

```bash
dotnet publish Blake2bTool/Blake2bTool.csproj \
  -c Release -r win-x64 \
  -p:PublishSingleFile=true -p:SelfContained=false \
  -p:DebugType=None -p:InvariantGlobalization=true
```

### Self-contained single file (no runtime needed)

Includes the runtime in the executable (larger size).

```bash
dotnet publish Blake2bTool/Blake2bTool.csproj \
  -c Release -r win-x64 \
  -p:PublishSingleFile=true -p:SelfContained=true \
  -p:DebugType=None -p:EnableCompressionInSingleFile=true \
  -p:InvariantGlobalization=true
```

> Note: `PublishTrimmed=true` is not supported/recommended for Windows Forms and will fail with `NETSDK1175`.

## Usage

- Select input source: Text or File (browse or drag-and-drop)
- Pick algorithm: `BLAKE2b` or `MD5`
- For BLAKE2b, optionally set `Key` and `Digest length` (1–64 bytes)
- Choose output format: `Hex` (uppercase toggle) or `Base64`
- Click `Compute` to get the digest and copy with `Copy`
- In File mode, use `Read File Times` to populate timestamps and `Apply File Times` to write them back

## Notes

- MD5 is not suitable for security-sensitive scenarios; prefer BLAKE2b
- Windows-only application (WinForms UI)