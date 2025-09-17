# 実行時間 20ms
n = int(input())
v = n
e = [True] * n
g = [[False] * n for _ in [0] * n]

for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    a -= 1
    b -= 1
    g[a][b] = True
    g[b][a] = True
while 2 < v:
    for i in range(n):
        cnt = 0

        for j in range(n):
            if g[i][j] == True:
                cnt += 1
        if cnt == 1:
            v -= 1
            e[i] = False
            g[i] = [False] * n
    for i in range(n):
        for j in range(n):
            if e[j] != True and g[i][j] == True:
                g[i][j] = False
for i in range(n):
    if e[i] == True:
        print(i + 1)
