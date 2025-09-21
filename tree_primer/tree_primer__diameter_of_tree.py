# 実行時間 10ms
from collections import deque

n = int(input())
x = -1
d = [-1] * (n + 1)
g = [[] for _ in [0] * (n + 1)]
q = deque()

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    g[a].append(b)
    g[b].append(a)
for i in range(1, n - 1):
    if 0 < len(g[i]):
        d[i] = 0
        q.append(i)
        break
while 0 < len(q):
    c = q.popleft()

    for i in g[c]:
        if d[i] == -1:
            d[i] = d[c] + 1
            if x < d[i]:
                x = d[i]
            q.append(i)
x = d.index(x)
d = [-1] * (n + 1)
d[x] = 0
q.append(x)
x = -1
while 0 < len(q):
    c = q.popleft()
    for i in g[c]:
        if d[i] == -1:
            d[i] = d[c] + 1
            if x < d[i]:
                x = d[i]
            q.append(i)
print(x)
