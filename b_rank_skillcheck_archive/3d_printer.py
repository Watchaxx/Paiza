# 実行時間 20ms
import sys

r = sys.stdin.readline
x, y, z = list(map(int, r().split()))
o = []

for i in range(z):
    t = ["." for _ in [0] * y]

    for _ in [0] * x:
        u = r().strip()

        for j in range(y):
            if u[j] == "#":
                t[j] = "#"
    o.append("".join(t))
    r()
o.reverse()
print("\n".join(o))
