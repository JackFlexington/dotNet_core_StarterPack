# GitHub Repository: dotNet_core_StarterPack

# Before we start
* This document assumes you have fundamental Linux command line interface understandings
  * [Very great tutorial for learning Linux commands](https://linuxjourney.com/)
* VI Text Editor is my editor of choice due to its portibitilty and how its on nearly all Linux systems.
  * [Hands-on down the best VIM Text Editor book](https://www.amazon.com/Mastering-Vim-Quickly-WTF-time/dp/1983325740)

# Environment Documentation
## Operating System Information
* Acquired image on 02/06/2021
* Ubuntu Desktop 20.04.2 LTS (file name = ```ubuntu-20.04.2-desktop-amd64.iso```)
* Debian-based
* ISO file size: ~2.67-gigs (exact = ```2,877,227,008 bytes```)
* Link: [Download Ubuntu Desktop](https://ubuntu.com/download/desktop)
* Link: [Release Notes](https://wiki.ubuntu.com/FocalFossa/ReleaseNotes)
* Note: If you're using a Virtual Machine via "VMware" or "Virtual Box" or one of the others... remember to mount the .iso image so that you may install the operating system with ease.
* Package Manager Information: [Advanced Package Tool(APT)](https://ubuntu.com/server/docs/package-management)

## Configuring the system
### Updating VI text editor
```bash
# [As ${USER}]
sudo su root
apt-get update && apt-get install -y vim
# Note: I'm not sure why, but the base update / upgrade doesn't seem to update the native VI text editor. Performing this step is highly recommended as it drastically improves the usability of VI.
exit # or (CTRL+D)
```
### Installing Git
```bash
# [As ${USER}]
sudo apt update
sudo apt install -y git
git --version
```

### Installing & Configuring Visual Studio Code for GitHub interaction
Source: [Install Visual Studio Code](https://linuxize.com/post/how-to-install-visual-studio-code-on-ubuntu-20-04/)
```bash
# [As ${USER}]
sudo apt update
sudo apt install -y software-properties-common apt-transport-https wget
wget -q https://packages.microsoft.com/keys/microsoft.asc -O- | sudo apt-key add -
sudo add-apt-repository "deb [arch=amd64] https://packages.microsoft.com/repos/vscode stable main"
sudo apt install -y code
```
1. Open Visual Studio Code (VS)
2. Open "Extensions" (Ctrl + Shift + X)
3. Search & Install "GitHub Pull Requests and Issues"
4. Navigate to bottom-left of VS screen to sign in, this will open up the browser and request you to sign into GitHub.
  * Note: If this doesn't work using Firefox... Follow the below section to install Google Chrome

#### Installing Google Chrome [OPTIONAL]
  ```bash
  # [As ${USER}]
  cd ~
  wget https://dl.google.com/linux/direct/google-chrome-stable_current_amd64.deb
  sudo apt install ./google-chrome-stable_current_amd64.deb
  sudo apt update && sudo apt -y upgrade
  ```
  * Search for "Default Applications" and set Google Chrome as default web browser.
  * Now when you navigate through the sign in process on GitHub, accept each one of the pop-ups to ensure that Visual Studio has everything it needs to appropriate as expected.

At this point, the connections to GitHub are complete. Feel free to uninstall Google Chrome should you wish to do so.
  * ```sudo apt-get remove -y google-chrome-stable``` for when you're done authenticating Visual Studio Code through Chrome. 
    * (Source: [Uninstall Google Chrome](https://askubuntu.com/questions/67047/how-to-uninstall-google-chrome))

Reboot the system by typing the following command ```reboot``` into the Terminal.

### Downloading/Installing .NET Core
* Grab the Linux-based BASH Shell Script [dotnet-install.sh](https://dot.net/v1/dotnet-install.sh) from Microsofts website.
* Copy and paste the code into a file within the Linux system
  * Example: 
  1. Create new file within Linux system ```vi install-core.sh```.
  2. Press "i" for (insert mode).
  3. Right-click for paste.
  4. Press ```esc``` to exit (insert mode).
  5. Save and exit out of the file using ```:wq``` (colon, w, q).
  6. Grant execute privileges to all ```chmod 777 install-core.sh```.
  7. Execute script ```./install-core.sh```.

### Install Software Developer Kit (SDK) for DotNet
```snap install dotnet-sdk --classic```

### Setup the project
```bash
cd ~
mkdir dotNetCore
cd dotNetCore
mkdir APP_NAME
mkdir APP_NAME/src
mkdir APP_NAME/test
mkdir APP_NAME/src/APP_NAME/
cd APP_NAME/src/APP_NAME
dotnet new console # Alternatively: dotnet new web.
dotnet run # To run the template version of created app.
```

### 

### Writing some simple

# Troubleshooting
* [Fix debugger](https://stackoverflow.com/questions/52063435/debugging-net-core-in-ubuntu-using-vscode)

# Sources: 
* [.NET Core webpage](https://dotnet.microsoft.com/download/dotnet/3.1)
* Web page instructions for [Linux Installation](https://docs.microsoft.com/en-us/dotnet/core/install/linux)

# Troubleshooting
* [Debugging using Linux](https://docs.microsoft.com/en-us/visualstudio/debugger/remote-debugging-dotnet-core-linux-with-ssh?view=vs-2019)
