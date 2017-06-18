## 作業規範：
只收 gist 與 GitHub, 強烈建議為 GitHub，因為 day 2 homework 只收 GitHub</br>
作業可以只交 test case，如果你想挑戰 production code 十分歡迎，但請務必先寫好 test case</br>
測試資料請勿使用迴圈產生，因為這資料只是「剛好」長這樣

## 題目解說
1. 來源可以是「任何型別的集合」
2. 可以任意決定幾筆一組
3. 回傳每一組 Σf(x) 的集合
    - Σ結果型別可直接用int

## Output:
Sample	activity	result
1	3筆一組，取Cost總和	6, 15, 24, 21
2	4筆一組，取Revenue總和	50, 66, 60


11 筆資料
名稱可以用更好的命名</br>
只要寫測試案例來描述需求</br>
不要用forloop</br>
可能任意筆一組</br>
可能多一筆原本沒有的</br>
可能以後有任意型別</br>
不用考慮易位跟空的</br>
負數筆的話噴 ArgumentException</br>
選不到的話就 ArgumentException</br>
一定從前三筆開始選
