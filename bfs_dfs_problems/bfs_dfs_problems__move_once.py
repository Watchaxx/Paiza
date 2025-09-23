# 実行時間 10ms
h, w = list(map(int, input().split()))
y, x = list(map(int, input().split()))
dx = [0, 0, -1, 1]
dy = [-1, 1, 0, 0]
g = [["." for _ in [0] * w] for _ in [0] * h]

g[y][x] = "*"
for i in range(4):
    a = x + dx[i]
    b = y + dy[i]

    if 0 <= b < h and 0 <= a < w:
        g[b][a] = "*"
for c in g:
    print("".join(c))
