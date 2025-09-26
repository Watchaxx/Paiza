# 実行時間 40ms
from collections import deque

n, m, x = list(map(int, input().split()))
u = [True] * n
g = [[] for _ in [0] * n]
q = deque()

u[x - 1] = False
for _ in [0] * m:
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
for l in g:
    l.sort()
q.append(x - 1)
while 0 < len(q):
    s = q.popleft()

    print(s + 1)
    for i in g[s]:
        if u[i] == True:
            u[i] = False
            q.append(i)
