# 実行時間 10ms
n = int(input())
g = [[0] * n for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a][b] = 1
    g[b][a] = 1
for i in range(n):
    print(*g[i])
