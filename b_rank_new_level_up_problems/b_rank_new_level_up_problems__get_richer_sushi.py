# 実行時間 60ms
import sys

rl = sys.stdin.readline
m = 0
n, k = list(map(int, rl().split()))
a = [0 for _ in [0] * (n * 2)]

for i in range(n):
    p = int(rl())

    a[i] = p
    a[i + n] = p
for i in range(n):
    p = 0

    for j in range(i, i + k):
        p += a[j]
    m = max(m, p)
print(m)
