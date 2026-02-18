# AndroidKeystoreCreator

### Prerequisites

- .NET 8 SDK installed.

### Clone the Repository

```bash
git clone https://github.com/algovoid/AndroidKeystoreCreator.git
cd AndroidKeystoreCreator
```

## Build Instructions

#### Windows Build :

run `build.bat`

## Linux Build

```bash
chmod +x build.sh
./build.sh
```

This generates portable, self-contained executables in:

```bash
src/AndroidKeystoreCreator/bin/Release/net8.0/{win-x64|linux-x64}/publish/
```

You can run the resulting executable directly, no .NET runtime is required on the target system.
