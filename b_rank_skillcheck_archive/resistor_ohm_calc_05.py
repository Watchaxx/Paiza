# 実行時間 10ms
import math

n = int(input())
o = 0
d = {}

for _ in [0] * n:
    s = input().split()

    d[s[0]] = int(s[1])
input()
for i in input().split():
    if len(i) == 1:
        o += d[i]
    else:
        t = 0

        for j in i:
            t += 1 / d[j]
        o += math.floor(1 / t)
print(o)
