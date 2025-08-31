# 実行時間 20ms
n = int(input())
l = 4
ng = [0, 0, 0, 0]
ok = [0, 0, 0, 0]
lv = ["A", "B", "C", "D", "E"]
ex = ["TA", "TB", "TC", "TD"]

for _ in range(n):
    t = input().split()

    for i in range(4):
        if t[0] == ex[i]:
            if t[1] == "ng":
                ng[i] += 1
            elif t[1] == "ok":
                ok[i] += 1
            if 2 <= ok[i] and ng[i] < 2:
                l = min(l, i)
print(lv[l])
