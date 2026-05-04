# imageZoom

一個簡單的圖片縮放小工具。
打開後輸入想要的寬、高，選一張或多張圖片，程式會把縮放後的圖片存到原資料夾下的 `resize\` 子資料夾。

- 開發語言：C#
- 框架：.NET 10（Windows Forms）
- 執行平台：Windows 10 / 11

---

## 第一次拿到專案？照這個順序做就好

### 步驟 1：安裝工具

需要安裝 **.NET SDK** 和 **編輯器**。編輯器可以二選一，看你習慣。

#### (1) .NET 10 SDK（必裝）

下載網址：<https://dotnet.microsoft.com/download/dotnet/10.0>
點 **SDK x64** 下載並安裝（不是 Runtime，是 SDK）。

#### (2) 編輯器：以下兩個**任選一個**安裝即可

**選項 A：Visual Studio Code（簡稱 VS Code）— 推薦給輕量、習慣指令的人**

- 下載網址：<https://code.visualstudio.com/>
- 優點：開啟快、檔案小
- 缺點：**沒有畫面拖拉工具**，要改視窗排版只能改程式碼

**選項 B：Visual Studio 2022 Community — 推薦給想用拖拉方式設計畫面的人**

- 下載網址：<https://visualstudio.microsoft.com/zh-hant/vs/community/>
- 個人 / 學習用途**完全免費**
- 安裝時，「工作負載 (Workloads)」頁面要勾選：
  - **.NET 桌面開發** (.NET desktop development)
- 優點：可以**雙擊 `mainForm.cs` 用拖拉介面**設計按鈕、文字框、視窗大小
- 缺點：安裝檔大（約 5–10 GB），開啟慢一點

> 兩個都裝也沒問題，不會衝突。新手建議先裝 **Visual Studio Community** 比較好上手。

### 步驟 2：確認 .NET 有裝成功

按 `Win + X` → 選「終端機」或「PowerShell」，輸入：

```powershell
dotnet --version
```

有看到 `10.x.x` 之類的版本號就成功了。
如果出現「找不到指令」，表示沒裝好，請回去步驟 1 重裝。

### 步驟 3：安裝擴充套件（只有 VS Code 需要）

> 用 Visual Studio 的人請**直接跳到步驟 4**，不需要做這步。

打開 VS Code，左邊欄有一個方塊圖示 (Extensions)，點下去搜尋並安裝：

- **C# Dev Kit**（搜尋這個名字第一個就是，發行者是 Microsoft）

裝好之後 VS Code 會自動把其他需要的東西一起裝起來。

### 步驟 4：打開專案

**如果你用 VS Code：**
左上角 **File → Open Folder**，選到 `imageZoom` 這個資料夾（**不是** `imageZoom\imageZoom`，要選最外層那個）。
第一次開啟時，右下角可能會跳通知問你要不要還原套件，點 **Yes / Restore** 即可。沒跳也沒關係，下面 build 的時候會自動處理。

**如果你用 Visual Studio：**
直接**雙擊 `imageZoom.sln`** 這個檔案，Visual Studio 會自動打開整個專案。
第一次開啟會花一點時間下載相依套件，等右下角跑完再操作。

---

## 怎麼編譯（Build）

「編譯」就是把寫好的程式碼變成可以執行的 `.exe` 檔。

**如果你用 VS Code：**
上方選單點 **Terminal → New Terminal**，會在下方打開一個命令列視窗，輸入：

```powershell
dotnet build
```

跑完最後一行看到 `Build succeeded` 就成功了。
如果看到紅字 `error`，把錯誤訊息貼給別人看或直接 Google。

**如果你用 Visual Studio：**
上方選單 **建置 (Build) → 建置方案 (Build Solution)**，或直接按 `Ctrl + Shift + B`。
下方「輸出」視窗會顯示結果，看到 `已成功 (Build succeeded)` 就完成了。

產生的執行檔會放在這裡：

```
imageZoom\bin\Debug\net10.0-windows\imageZoom.exe
```

---

## 怎麼執行（Run）

挑一個你喜歡的方式：

### 方法 A：在 VS Code 執行

1. 點開左邊任何一個 `.cs` 檔（例如 `mainForm.cs`）
2. 按 `F5`
3. 第一次會跳出選項，選 **C#** 即可
4. 程式視窗就會打開

之後想停止程式，關掉視窗或按 VS Code 上方的紅色方塊就可以。

### 方法 B：在 Visual Studio 執行

直接按 `F5`（偵錯執行）或 `Ctrl + F5`（不進偵錯直接跑）。
上方綠色三角形按鈕也可以。
要停止程式：關掉程式視窗，或按上方的紅色方塊。

### 方法 C：在終端機輸入指令（不論用哪個編輯器都可以）

```powershell
dotnet run --project imageZoom\imageZoom.csproj
```

---

## 怎麼修改程式

主要會改到的檔案：

| 檔案 | 用途 |
| --- | --- |
| `imageZoom\mainForm.cs` | **程式邏輯**（按下按鈕後做什麼）→ 大部分時間會改這裡 |
| `imageZoom\mainForm.Designer.cs` | **畫面排版**（按鈕、文字框的位置、大小） |
| `imageZoom\Program.cs` | 程式進入點，通常不用動 |

修改流程：

1. 改完程式碼，**存檔**（`Ctrl + S`）
2. 按 `F5` 執行看看
3. 如果跳錯誤訊息，看訊息哪一行有問題，回去改

> **小提醒**：`mainForm.Designer.cs` 是 Visual Studio 的拖拉介面工具自動產生的。
> 用 **Visual Studio** 的人：雙擊 `mainForm.cs` 會直接打開拖拉介面，改完存檔即可，不用碰 `Designer.cs`。
> 用 **VS Code** 的人：沒有拖拉工具，要改畫面只能直接動 `Designer.cs` 的程式碼，建議先把舊的數字記下來再改，免得改壞了回不去。

---

## 常見問題

**Q：按 `dotnet build` 出現「不是內部或外部命令」？**
A：.NET SDK 沒裝好，或裝完沒有重開終端機。先關掉 VS Code 再開一次。

**Q：執行後找不到我輸出的圖片？**
A：圖片會存在你**選圖時的那個資料夾**底下的 `resize\` 子資料夾，不是程式的資料夾。

**Q：跳出 `Width & Height must be a number.`？**
A：寬度或高度的欄位填了非數字（例如空白或文字），改成數字就好。

**Q：我想改畫面（按鈕位置、視窗大小），但不想寫程式？**
A：用 **Visual Studio Community**（免費）開啟 `imageZoom.sln`，雙擊 `mainForm.cs` 就會出現拖拉介面，可以直接拖、直接改。

---

## 專案結構

```
imageZoom\
├─ imageZoom.sln                 方案檔（VS Code 從這裡認識整個專案）
├─ README.md                     這份說明
└─ imageZoom\
   ├─ imageZoom.csproj           專案設定檔
   ├─ Program.cs                 程式進入點
   ├─ mainForm.cs                主視窗邏輯 ← 大部分修改在這
   ├─ mainForm.Designer.cs       畫面排版
   ├─ mainForm.resx              資源檔（圖片、字串等）
   └─ Properties\
```
