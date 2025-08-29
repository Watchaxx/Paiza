# 実行時間 3480ms
import sys

rl = sys.stdin.readline
n = int(rl())
o = 1
a = []
p = [1]

for _ in [0] * n:
    a.append(int(rl()))
for i in range(1, n):
    p.append(1)
    for j in range(i):
        if a[i] < a[j]:
            if p[i] < p[j] + 1:
                p[i] = p[j] + 1
            if o < p[i]:
                o = p[i]
print(o)
