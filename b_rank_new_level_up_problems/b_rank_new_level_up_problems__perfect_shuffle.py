# 実行時間 20ms
k = int(input())
kd = ["S", "H", "D", "C"]
l = []

for i in range(4):
    for j in range(1, 14):
        l.append([f"{kd[i]}_{j}", 0])
for _ in range(k):
    for i in range(len(l)):
        l[i][1] = i * 2 if i < 26 else (i - 26) * 2 + 1
    l.sort(key=lambda x: x[1])
for i in l:
    print(i[0])
