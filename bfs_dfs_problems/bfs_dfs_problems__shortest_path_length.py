# 実行時間 30ms
from collections import deque

n, m, x, y = list(map(int, input().split()))
d = [-1] * n
g = [[] for _ in [0] * n]
q = deque()

d[x - 1] = 0
for _ in [0] * m:
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
q.append(x - 1)
while 0 < len(q):
    s = q.popleft()

    for i in g[s]:
        if d[i] < 0:
            d[i] = d[s] + 1
            q.append(i)
print(d[y - 1])
