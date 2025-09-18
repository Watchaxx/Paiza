# 実行時間 10ms
from collections import deque

n, r = list(map(int, input().split()))
d = [-1] * n
e = [list(map(int, input().split())) for _ in [0] * (n - 1)]
g = [[] for _ in [0] * n]
q = deque()

d[r - 1] = 0
for i in range(n - 1):
    a, b = e[i]

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
q.append(r - 1)
while 0 < len(q):
    c = q.popleft()

    for i in g[c]:
        if d[i] == -1:
            d[i] = d[c] + 1
            q.append(i)
for i in range(n - 1):
    print("A" if d[e[i][0] - 1] < d[e[i][1] - 1] else "B")
