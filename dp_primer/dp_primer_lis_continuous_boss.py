# 実行時間 120ms
import sys

rl = sys.stdin.readline
n = int(rl())
o = 1
a = []
p = [1]

for _ in [0] * n:
    a.append(int(rl()))
for i in range(1, n):
    t = p[i - 1] + 1 if a[i] <= a[i - 1] else 1

    p.append(t)
    if o < t:
        o = t
print(o)
