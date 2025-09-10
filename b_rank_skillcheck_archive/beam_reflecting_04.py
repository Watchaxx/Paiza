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
    if (dx == 0 and dy == -1 and s[py][px] == "/") or (
        dx == 0 and dy == 1 and s[py][px] == "\\"
    ):
        dx = 1
        dy = 0
    elif (dx == 0 and dy == 1 and s[py][px] == "/") or (
        dx == 0 and dy == -1 and s[py][px] == "\\"
    ):
        dx = -1
        dy = 0
    elif (dx == 1 and dy == 0 and s[py][px] == "/") or (
        dx == -1 and dy == 0 and s[py][px] == "\\"
    ):
        dx = 0
        dy = -1
    elif (dx == -1 and dy == 0 and s[py][px] == "/") or (
        dx == 1 and dy == 0 and s[py][px] == "\\"
    ):
        dx = 0
        dy = 1
print(o)
