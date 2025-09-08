# 実行時間 170ms
import sys

r = sys.stdin.readline
o = 0
n, m = list(map(int, r().split()))

if n != 0:
    for _ in [0] * m:
        e = sum(list(map(int, r().split())))

        if 0 < e:
            o += e
print(o)
