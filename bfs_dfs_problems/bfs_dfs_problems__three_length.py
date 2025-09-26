# 実行時間 390ms
from collections import deque

n, x = list(map(int, input().split()))
d = [-1] * n
g = [[] for _ in [0] * n]
q = deque()

x -= 1
d[x] = 0
for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
q.append(x)
while 0 < len(q):
    s = q.popleft()

    for i in g[s]:
        if d[i] == -1:
            d[i] = d[s] + 1
            q.append(i)
for i, j in enumerate(d):
    if j == 3:
        print(i + 1)
