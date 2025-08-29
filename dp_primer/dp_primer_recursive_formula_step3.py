# 実行時間 10ms
import sys

rl = sys.stdin.readline
x, d1, d2 = list(map(int, rl().split()))
q = int(rl())
a = [x]

for i in range(1, 1000):
    a.append(a[-1] + d1 if i % 2 == 0 else a[-1] + d2)
for _ in [0] * q:
    print(a[int(rl()) - 1])
