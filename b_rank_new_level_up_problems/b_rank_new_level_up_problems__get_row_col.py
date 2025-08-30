# 実行時間 10ms
import sys

rl = sys.stdin.readline
h, w = list(map(int, rl().split()))
b = [[False for _ in [0] * w] for _ in [0] * h]

for i in range(h):
    s = rl()

    for j in range(w):
        b[i][j] = s[j] == "#"

y, x = list(map(int, rl().split()))

for i in range(h):
    for j in range(w):
        if i + j == y + x or i - j == y - x or i == y or j == x:
            b[i][j] = not b[i][j]
for i in range(h):
    for j in range(w):
        print("#" if b[i][j] else ".", end="")
    print()
