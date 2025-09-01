# 実行時間 20ms
from math import sqrt

px, py = list(map(int, input().split()))
n = int(input())
d1 = [[0, 0] for _ in range(n)]
d2 = [[0, 0] for _ in range(n)]

for i in range(n):
    t = list(map(int, input().split()))

    d1[i][0] = sqrt((px - t[0]) ** 2 + (py - t[1]) ** 2)
    d1[i][1] = i + 1
    d2[i][0] = abs(px - t[0]) + abs(py - t[1])
    d2[i][1] = i + 1
d1.sort(key=lambda x: (x[0], x[1]))
d2.sort(key=lambda x: (x[0], x[1]))
for i in range(3):
    print(d1[i][1])
for i in range(3):
    print(d2[i][1])
