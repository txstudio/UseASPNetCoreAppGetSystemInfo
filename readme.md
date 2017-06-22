# 使用 ASP.NET Core 操作伺服器指令

此專案為透過 ASP.NET Core 建立的網際網路應用程式，並可執行在 Windows 與 Linux 作業系統（手邊沒有 Mac 無法試）。

### 網站僅提供下列功能

#### 取得伺服器名稱
* 使用 System.Net 取得電腦名稱

#### 重新啟動電腦
* 使用命令提示字元執行重啟指令
* Windows 使用 cmd
* Linux 使用 /bin/bash
	
### 檔案說明

#### OperatingSystemPlatform
判斷網站目前架設在哪一個版本的作業系統（Mac, Linux, Windows）

#### PromptManager
透過命令提示字元的方式進行伺服器操作
提供 Linux 實作與 Windows 實作

#### WebApp
參考 PromptManager 與 OperatingSystemPlatform 提供不同做系統實作命令提示字元操作。

#### etc-systemd-system
Ubuntu Server 設定服務的設定檔案

#### release
網站應用程式部署檔案


### 參考資料

[.NET Core 判斷作業系統版本](https://blog.mariusschulz.com/2017/02/28/detecting-the-operating-system-in-net-core)

[將 ASP.NET Core 應用程式設定成服務](https://docs.microsoft.com/en-us/aspnet/core/publishing/linuxproduction#monitoring-our-application)

[Linux 環境使用命令提示字元](https://stackoverflow.com/questions/38962263/cannot-execute-linux-commands-from-a-dotnet-core-asp-net-solution)
