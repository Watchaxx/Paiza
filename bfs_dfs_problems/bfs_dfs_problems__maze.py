# 実行時間 10ms
from collections import deque

h, w = list(map(int, input().split()))
sy, sx = list(map(int, input().split()))
gy, gx = list(map(int, input().split()))
dx = [0, 0, -1, 1]
dy = [-1, 1, 0, 0]
d = [[-1] * w for _ in [0] * h]
g = [list(input()) for _ in [0] * h]
q = deque()

d[sy][sx] = 0
q.append((sy, sx))
while 0 < len(q):
    t = q.popleft()

    for i in range(4):
        x = t[1] + dx[i]
        y = t[0] + dy[i]

        if 0 <= x < w and 0 <= y < h and g[y][x] == "." and d[y][x] < 0:
            d[y][x] = d[t[0]][t[1]] + 1
            q.append((y, x))

print(d[gy][gx] if 0 <= d[gy][gx] else "No")
