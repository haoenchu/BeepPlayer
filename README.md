# 🎵 BeePlayer - 電子琴

這是一個基於 C# Windows Forms 製作的簡易電子琴。
<img width="545" height="421" alt="image" src="https://github.com/user-attachments/assets/bd96dc19-96aa-47fb-bdb9-d2b367300cf8" />


---

## 🚀 核心功能

### 1. 🎹 簡易電子琴 (Simple Piano)
**硬體發聲**：調用 `kernel32.dll` 中的 `Beep` 函式，直接驅動系統喇叭發出指定頻率的聲音 [cite: 167, 168, 177]。
**音階範圍**：支援 8 個音階（低音 Do 至高音 Do），頻率範圍為 523Hz ~ 1046Hz [cite: 220]。
**歌譜**：內建下拉式選單供使用者選擇曲目，標籤會自動顯示對應簡譜，並支援長曲譜自動換行顯示。

### 3. 📏 動態佈局縮放 (Smart Resizing)
**初始記憶**：程式啟動時會將所有控制項的原始座標與大小存入 `Dictionary<string, Rectangle>` [cite: 241, 248, 249]。
**比例自適應**：當使用者拉動視窗或面板（palMain）大小時，程式會自動計算縮放比例，即時調整按鈕、下拉選單與標籤的位置與寬度 [cite: 254, 260-262]。
<img width="1280" height="720" alt="Video Project 3" src="https://github.com/user-attachments/assets/dade62e8-df89-4001-85b4-bfb5e6e186ba" />

---

## 🛠️ 技術規格

* **開發語言**：C# 
* **視窗框架**：Windows Forms (WinForms)
* **關鍵技術**：
    **P/Invoke**：引用 `System.Runtime.InteropServices` 來使用 Win32 API [cite: 170]。
    **事件驅動**：利用 `SizeChanged` 事件觸發介面重繪邏輯 [cite: 252, 254]。
    **資料結構**：使用 `Dictionary` 實現對控制項狀態的高效管理 [cite: 241]。

---

## 📖 內建曲譜清單 (1~8 代表音階)

| 曲目名稱 | 完整簡譜 (部分預覽) |
| :--- | :--- |
| **小星星** | 1 1 5 5 6 6 5 - 4 4 3 3 2 2 1 - 5 5 4 4 3 3 2... |
| **瑪莉有隻小綿羊** | 3 2 1 2 3 3 3 - 2 2 2 - 3 5 5 - 3 2 1 2 3 3 3 3... |
| **兩隻老虎** | 1 2 3 1  1 2 3 1  3 4 5 -  3 4 5 -  5 6 5 4... |



