import math

n, k = list(map(int, input().split()))
sq = math.floor(math.sqrt(n))
s = []
mn = [0 for _ in range(sq)]
mx = [0 for _ in range(sq)]

for _ in range(n):
    s.append(int(input()))
for i in range(sq):
    for j in range(sq):
        mn[i] = s[sq * i] if j == 0 else min(mn[i], s[sq * i + j])
        mx[i] = s[sq * i] if j == 0 else max(mx[i], s[sq * i + j])
for _ in range(k):
    lr = list(map(int, input().split()))
    for i in range(len(lr)):
        lr[i] -= 1
    idx = lr[0]
    amn = s[lr[0]]
    amx = s[lr[0]]

    while idx <= lr[1]:
        if idx % sq == 0 and idx + sq - 1 <= lr[1]:
            amn = min(amn, mn[idx // sq])
            amx = max(amx, mx[idx // sq])
            idx += sq
        else:
            amn = min(amn, s[idx])
            amx = max(amx, s[idx])
            idx += 1
    idx = lr[2]

    bmn = s[lr[2]]
    bmx = s[lr[2]]

    while idx <= lr[3]:
        if idx % sq == 0 and idx + sq - 1 <= lr[3]:
            bmn = min(bmn, mn[idx // sq])
            bmx = max(bmx, mx[idx // sq])
            idx += sq
        else:
            bmn = min(bmn, s[idx])
            bmx = max(bmx, s[idx])
            idx += 1
    print("A" if bmx - bmn < amx - amn else "B" if amx - amn < bmx - bmn else "DRAW")
# 実行時間 9930ms
