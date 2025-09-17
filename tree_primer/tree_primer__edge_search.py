# 実行時間 10ms
n, k = list(map(int, input().split()))
g = [[] for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    g[a - 1].append(b)
    g[b - 1].append(a)
for _ in [0] * k:
    a, b = list(map(int, input().split()))

    print("YES" if b in g[a - 1] else "NO")
