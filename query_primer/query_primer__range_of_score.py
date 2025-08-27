# 実行時間 4510ms
import math
import sys

rl = sys.stdin.readline
n, k = list(map(int, rl().split()))
sq = math.floor(math.sqrt(n))
o = []
s = []
mn = [0 for _ in range(sq)]
mx = [0 for _ in range(sq)]

for _ in [0] * n:
    s.append(int(rl()))
for i in range(sq):
    for j in range(sq):
        mn[i] = s[sq * i] if j == 0 else min(mn[i], s[sq * i + j])
        mx[i] = s[sq * i] if j == 0 else max(mx[i], s[sq * i + j])
for _ in [0] * k:
    al, ar, bl, br = [int(t) - 1 for t in rl().split()]
    i = al
    amn = s[al]
    amx = s[al]

    while i <= ar:
        if i % sq == 0 and i + sq - 1 <= ar:
            if mn[i // sq] < amn:
                amn = mn[i // sq]
            if amx < mx[i // sq]:
                amx = mx[i // sq]
            i += sq
        else:
            if s[i] < amn:
                amn = s[i]
            if amx < s[i]:
                amx = s[i]
            i += 1
    i = bl

    bmn = s[bl]
    bmx = s[bl]

    while i <= br:
        if i % sq == 0 and i + sq - 1 <= br:
            if mn[i // sq] < bmn:
                bmn = mn[i // sq]
            if bmx < mx[i // sq]:
                bmx = mx[i // sq]
            i += sq
        else:
            if s[i] < bmn:
                bmn = s[i]
            if bmx < s[i]:
                bmx = s[i]
            i += 1
    o.append("A" if bmx - bmn < amx - amn else "B" if amx - amn < bmx - bmn else "DRAW")
print("\n".join(o))
