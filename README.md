🖥️ Windows System Utilities Launcher (C# WinForms)
A simple and organized Windows Forms application in C# that provides quick access to various built-in Windows tools and system management commands via a tabbed interface.

📌 Features
The application is divided into tabs for easy navigation. Each tab contains buttons or links that launch commonly used Windows utilities and commands directly.

🛠️ System Commands and Computer Management
services.msc – Open the Services Manager

taskschd.msc – Access the Task Scheduler

diskmgmt.msc – Manage partitions and disks

devmgmt.msc – Open the Device Manager

compmgmt.msc – Access Computer Management tools

wmimgmt.msc – Open the WMI Management Console

msconfig – Configure startup and services

perfmon.msc – Launch the Performance Monitor

secpol.msc – Configure local security policies

gpedit.msc – Manage local group policies

⚙️ Control Panel Tools
appwiz.cpl – Manage installed programs

control folders – Access Folder Options

desk.cpl – Configure display settings

intl.cpl – Set regional and language options

timedate.cpl – Set the date and time

sysdm.cpl – Open System Properties

firewall.cpl – Manage Windows Firewall

powercfg.cpl – Modify power settings

mmsys.cpl – Configure audio devices

🌐 Network and Connectivity
ipconfig – Display and configure IP settings

wf.msc – Manage advanced firewall settings

ncpa.cpl – Access network connections

netplwiz – Manage user access rights

ping [IP] – Check network connectivity

tracert [IP] – Diagnose the network path

netsh wlan show profiles – List saved Wi-Fi profiles

🧰 Built-In Windows Tools
notepad – Open Notepad

msinfo32 – System Information

mstsc – Remote Desktop Connection

calc – Open Calculator

mspaint – Launch Paint

snippingtool – Open Snipping Tool

magnify – Open Magnifier

osk – On-Screen Keyboard

📂 Miscellaneous Commands
%temp% – Temporary files folder

%userprofile% – Active user's folder

%windir% – Windows folder

explorer – File Explorer

rstrui – Launch System Restore

🚀 Getting Started
Prerequisites
Windows OS (Tested on Windows 10/11)

.NET Framework (version used during development)

Visual Studio (for building from source)

Running the App
Clone this repository:

bash
Copy
Edit
git clone https://github.com/your-username/your-repo-name.git
Open the solution in Visual Studio.

Build and run the project (F5).

⚠️ Note: Some commands may require administrator privileges to execute.

🧩 Folder Structure
bash
Copy
Edit
/WindowsSystemUtilitiesLauncher
│
├── Forms/
│   ├── MainForm.cs         # Contains tabbed UI
│   └── Helpers.cs          # Optional: contains command execution logic
│
├── Program.cs              # Application entry point
├── README.md
└── WindowsSystemUtilitiesLauncher.sln
📃 License
This project is licensed under the MIT License. See the LICENSE file for more info.

🙋‍♂️ Contributing
Feel free to fork this project and open pull requests for:

UI improvements

Additional system commands

Bug fixes or optimizations

