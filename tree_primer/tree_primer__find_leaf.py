# 実行時間 10ms
n = int(input())
g = [[] for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    g[a - 1].append(b)
    g[b - 1].append(a)
for i in range(n):
    if len(g[i]) == 1:
        print(i + 1)
