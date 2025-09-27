# 実行時間 10ms
def dfs(y, x):
    s[y][x] = "#"
    for i in range(-1, 2, 2):
        if 0 <= y + i < h and s[y + i][x] == ".":
            dfs(y + i, x)
        if 0 <= x + i < w and s[y][x + i] == ".":
            dfs(y, x + i)

o = 0
h, w = list(map(int, input().split()))
s = [list(input()) for _ in [0] * h]

for i in range(h):
    for j in range(w):
        if s[i][j] == ".":
            dfs(i, j)
            o += 1
print(o)
