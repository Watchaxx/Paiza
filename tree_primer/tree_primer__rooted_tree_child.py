# 実行時間 10ms
n, k, r = list(map(int, input().split()))
g = [[] for _ in [0] * (n + 1)]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    g[a].append(b)
for _ in [0] * k:
    print(*sorted(g[int(input())]))
