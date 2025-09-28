# 実行時間 10ms
from collections import deque

def dfsf(v, s, g):
    global dfs

    s[v] = True
    if s[y] != True:
        dfs += 1
    for i in g[v]:
        if s[i] != True:
            dfsf(i, s, g)

n, x, y = list(map(int, input().split()))
bfs = 0
dfs = 0
bb = [False] * n
bd = [False] * n
g = [[] for _ in [0] * n]
q = deque()

x -= 1
y -= 1
bb[x] = True
for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
for l in g:
    l.sort()
q.append(x)
while 0 < len(q):
    v = q.popleft()

    if v == y:
        break
    else:
        bfs += 1
    for i in g[v]:
        if bb[i] != True:
            bb[i] = True
            q.append(i)
dfsf(x, bd, g)
print("bfs" if bfs < dfs else "dfs" if dfs < bfs else "same")
