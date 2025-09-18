# 実行時間 10ms
def getLen(c):
    for i in g[c]:
        if l[i] == -1:
            l[i] = l[c] + 1
            p[i] = c
            getLen(i)

n, t, s, c, d = list(map(int, input().split()))
g = [[] for _ in [0] * n]
l = [-1] * n
p = [0] * n

t -= 1
s -= 1
l[t] = 0
p[t] = -1
for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a].append(b)
    g[b].append(a)
getLen(t)
if l[s] <= c:
    for i in range(n):
        if l[i] == l[s] - c + d:
            print(i + 1)
else:
    h = s

    for _ in range(c):
        h = p[h]
    for i in range(n):
        if l[i] == l[s] - c + d:
            z = i

            for _ in range(d):
                z = p[z]
            if z == h:
                print(i + 1)
