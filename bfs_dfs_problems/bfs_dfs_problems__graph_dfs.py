# 実行時間 30ms
import sys

def dfs(v, s, g):
    s[v] = True
    print(v + 1)
    for i in g[v]:
        if s[i] != True:
            dfs(i, s, g)

sys.setrecursionlimit(10000)
n, m, x = list(map(int, input().split()))
s = [False] * n
g = [[] for _ in [0] * n]

for _ in [0] * m:
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
for l in g:
    l.sort()
dfs(x - 1, s, g)
