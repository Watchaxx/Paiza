# 実行時間 10ms
dx = 1
dy = 0
o = 0
px = -1
py = 0
h, w = list(map(int, input().split()))
s = []

for _ in [0] * h:
    s.append(input())
while True:
    px += dx
    py += dy
    if px < 0 or w <= px or py < 0 or h <= py:
        break
    o += 1
    if s[py][px] == "R":
        dx = 1
        dy = 0
    elif s[py][px] == "L":
        dx = -1
        dy = 0
    elif s[py][px] == "U":
        dx = 0
        dy = -1
    elif s[py][px] == "D":
        dx = 0
        dy = 1
print(o)
