# 実行時間 10ms
def dfs(v, g, s):
    s[v] = True
    print(v + 1)
    for w in g[v]:
        if s[w] != True:
            dfs(w, g, s)

n, x = list(map(int, input().split()))
s = [False] * n
g = [[] for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
for l in g:
    l.sort()
dfs(x - 1, g, s)
