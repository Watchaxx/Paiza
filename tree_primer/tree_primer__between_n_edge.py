# 実行時間 10ms
from collections import deque

n, a, x = list(map(int, input().split()))
d = [-1] * (n + 1)
g = [[] for _ in [0] * (n + 1)]
q = deque()

d[a] = 0
for _ in [0] * (n - 1):
    i, j = list(map(int, input().split()))

    g[i].append(j)
    g[j].append(i)
q.append(a)
while 0 < len(q):
    v = q.popleft()

    for i in g[v]:
        if d[i] == -1:
            d[i] = d[v] + 1
            q.append(i)
for i in range(n + 1):
    if d[i] == x:
        print(i)
