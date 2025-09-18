# 実行時間 10ms
n = int(input())
t = 0
g = [[] for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
for l in g:
    t += len(l) * (len(l) - 1) // 2
print("paiza" if t % 2 != 0 else "erik")
