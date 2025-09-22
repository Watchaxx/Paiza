# 実行時間 10ms
from collections import deque

n, r = list(map(int, input().split()))
g = [[] for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)

k, r = list(map(int, input().split()))
d = [-1] * n
q = deque()

d[r - 1] = 0
q.append(r - 1)
while 0 < len(q):
    c = q.popleft()

    for i in g[c]:
        if d[i] == -1:
            d[i] = d[c] + 1
            q.append(i)
for _ in [0] * k:
    v = int(input()) - 1

    for i in g[v]:
        if d[i] + 1 == d[v]:
            print(i + 1)
