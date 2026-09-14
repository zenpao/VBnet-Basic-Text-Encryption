# VBnet-Basic-Text-Encryption

A basic Windows Forms desktop app (VB.NET) for encrypting and decrypting text using a fixed Caesar-cipher-style character shift.

## Description

The app provides a single text box with **Encrypt** and **Decrypt** buttons. Encrypting shifts each character's ASCII code up by 3; decrypting shifts it back down by 3. This is a simple substitution cipher intended for basic/educational use, not for securing sensitive data.

## Features

- Encrypt text in-place in the text box (character-code shift of +3)
- Decrypt text in-place in the text box (character-code shift of -3)
- Simple single-window interface

## Tech Stack

- **VB.NET** (Visual Basic .NET)
- **Windows Forms** (WinForms)
- **.NET Framework 4.5**

## Prerequisites

- Windows OS
- [.NET Framework 4.5](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net45) or later (for running the built app)
- Visual Studio (for building/editing the project — any edition supporting VB.NET WinForms projects and .NET Framework 4.5)

## Installation

Clone the repository:

```bash
git clone https://github.com/paoradox/VBnet-Basic-Text-Encryption.git
```

Open `EncryptDecrypt.sln` in Visual Studio.

## Usage

1. Build and run the project in Visual Studio (or run the compiled `EncryptDecrypt.exe` directly, once built).
2. Type or paste text into the text box.
3. Click **Encrypt** to shift the text, or **Decrypt** to reverse a previously encrypted shift.

## Project Structure

```
VBnet-Basic-Text-Encryption/
├── My Project/                  # VB.NET project settings, assembly info, resources
├── bin/Debug/                   # Debug build output
├── obj/Debug/                   # Build intermediates
├── EncryptDecrypt.sln           # Visual Studio solution file
├── EncryptDecrypt.vbproj        # Project file (.NET Framework 4.5, WinForms)
├── Form1.vb                     # Encrypt/decrypt logic and button event handlers
├── Form1.Designer.vb            # Form layout (text box, Encrypt/Decrypt buttons)
├── Form1.resx                   # Form resources
├── App.config                   # Application configuration
└── EncryptDecrypt.exe.lnk       # Shortcut to the built executable
```

## License

Apache License 2.0
