# 実行時間 380ms
from collections import deque

n, x, y = list(map(int, input().split()))
d = [-1] * n
p = [-1] * n
g = [[] for _ in [0] * n]
o = []
q = deque()

x -= 1
y -= 1
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

    if s == y:
        break
    for i in g[s]:
        if d[i] == -1:
            d[i] = d[s] + 1
            p[i] = s
            q.append(i)
while y != -1:
    o.append(y)
    y = p[y]
for i in o[::-1]:
    print(i + 1)
