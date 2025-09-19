# 実行時間 10ms
import sys

rl = sys.stdin.readline
n, k, r = list(map(int, rl().split()))
g = [[0] * 2 for _ in [0] * (n + 1)]

for _ in [0] * (n - 1):
    s = rl().split()

    if s[2][0] == "L":
        g[int(s[0])][0] = int(s[1])
    elif s[2][0] == "R":
        g[int(s[0])][1] = int(s[1])
for _ in [0] * k:
    s = rl().split()
    i = g[int(s[0])]

    if s[1][0] == "L":
        print(i[0] if i[0] != 0 else "")
    elif s[1][0] == "R":
        print(i[1] if i[1] != 0 else "")
