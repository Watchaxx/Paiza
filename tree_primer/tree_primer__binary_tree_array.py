# 実行時間 10ms
import sys

rl = sys.stdin.readline
n, k, r = list(map(int, rl().split()))
bt = [0] * (2 * n)
lo = {}

bt[0] = r
lo[r] = 0
for _ in [0] * (n - 1):
    a, b, d = rl().split()
    b = int(b)

    if d == "L":
        lo[b] = 2 * lo[int(a)] + 1
    elif d == "R":
        lo[b] = 2 * lo[int(a)] + 2
    bt[lo[b]] = b
for _ in [0] * k:
    v, d = rl().split()

    if d == "L":
        print(bt[2 * lo[int(v)] + 1])
    elif d == "R":
        print(bt[2 * lo[int(v)] + 2])
