# 実行時間 10ms
from collections import deque

n, a, b = list(map(int, input().split()))
o = []
p = [-1] * n
g = [[] for _ in [0] * n]
q = deque()

a -= 1
b -= 1
p[a] = -2
for _ in [0] * (n - 1):
    x, y = list(map(int, input().split()))

    x -= 1
    y -= 1
    g[x].append(y)
    g[y].append(x)
q.append(a)
while 0 < len(q):
    c = q.popleft()

    for i in g[c]:
        if p[i] == -1:
            p[i] = c
            q.append(i)
while p[b] != -2:
    o.append(b)
    b = p[b]
o.append(b)
for i in o[::-1]:
    print(i + 1)
