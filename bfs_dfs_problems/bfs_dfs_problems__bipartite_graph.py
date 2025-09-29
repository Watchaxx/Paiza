# 実行時間 30ms
import sys

sys.setrecursionlimit(10000)
def dfs(v, l, c, g):
    c[v] = l
    for i in g[v]:
        if c[i] == 0:
            dfs(i, -l, c, g)
        elif c[i] == c[v]:
            global b
            b = False

b = True
n, m = list(map(int, input().split()))
c = [0] * n
g = [[] for _ in [0] * n]

for _ in [0] * m:
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
for i in range(n):
    if c[i] == 0:
        dfs(i, 1, c, g)
print("Yes" if b else "No")
