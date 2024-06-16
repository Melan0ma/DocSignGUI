; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "DocSignInt"
#define MyAppVersion "1.0"
#define MyAppPublisher "12 SLSC"
#define MyAppExeName "DocSignGUI.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{3459946A-D497-4766-A5B4-5C326548C16C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName=DocSign
AllowNoIcons=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=G:\Projects\DocSignGUI\DocSignGUI\bin\Release\Internal Network
OutputBaseFilename=mysetup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "G:\Projects\DocSignGUI\DocSignGUI\bin\Release\Internal Network\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "G:\Projects\DocSignGUI\DocSignGUI\bin\Release\Internal Network\DocSignGUI.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "G:\Projects\DocSignGUI\DocSignGUI\bin\Release\Internal Network\DocSignGUI.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "G:\Projects\DocSignGUI\DocSignGUI\bin\Release\Internal Network\MetroFramework.Design.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "G:\Projects\DocSignGUI\DocSignGUI\bin\Release\Internal Network\MetroFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "G:\Projects\DocSignGUI\DocSignGUI\bin\Release\Internal Network\MetroFramework.Fonts.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

