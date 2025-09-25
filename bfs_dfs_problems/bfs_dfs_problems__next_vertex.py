# 実行時間 260ms
n, x = map(int, input().split())
g = [[] for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = map(int, input().split())

    g[a - 1].append(b)
    g[b - 1].append(a)
for i in sorted(g[x - 1]):
    print(i)
