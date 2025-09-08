# 実行時間 10ms
import sys

r = sys.stdin.readline
o = 0
n, m = list(map(int, r().split()))

for _ in [0] * m:
    e = int(r())

    if 0 < e:
        o += e
print(o)
