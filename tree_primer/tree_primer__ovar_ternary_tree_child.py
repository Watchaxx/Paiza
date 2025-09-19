# 実行時間 10ms
import sys

rl = sys.stdin.readline
n, k, r = list(map(int, input().split()))
d = {}

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    if a not in d:
        d[a] = [b]
    else:
        d[a].append(b)
for _ in [0] * k:
    v, l = list(map(int, input().split()))

    print(d[v][l - 1])
