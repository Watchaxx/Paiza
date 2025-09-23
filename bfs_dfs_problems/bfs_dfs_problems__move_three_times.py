# 実行時間 10ms
h, w = list(map(int, input().split()))
y, x = list(map(int, input().split()))
dx = [0, 0, -1, 1]
dy = [-1, 1, 0, 0]
g = [["." for _ in [0] * w] for _ in [0] * h]
l = [[] for _ in [0] * 4]

g[y][x] = "*"
l[0].append((y, x))
for i in range(3):
    for t in l[i]:
        for j in range(4):
            a = t[1] + dx[j]
            b = t[0] + dy[j]

            if 0 <= b < h and 0 <= a < w:
                g[b][a] = "*"
                l[i + 1].append((b, a))
for c in g:
    print("".join(c))
