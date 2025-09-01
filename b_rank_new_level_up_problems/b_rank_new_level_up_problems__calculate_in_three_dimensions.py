# 実行時間 60ms
n = int(input())
o = 0
a = [[[0 for _ in range(n)] for _ in range(n)] for _ in range(n)]

for i in range(n):
    for j in range(n):
        a[i][j] = list(map(int, input().split()))
for i in range(n):
    for j in range(n):
        o = max(o, sum(a[i][j]))
for i in range(n):
    for j in range(n):
        o = max(o, sum(a[j][i]), sum(a[k][i][j] for k in range(n)))
for i in range(n):
    for j in range(n):
        o = max(o, sum(a[j][k][i] for k in range(n)), sum(a[k][j][i] for k in range(n)))
for i in range(n):
    o = max(o, sum(a[i][j][j] for j in range(n)), sum(a[i][n - 1 - j][j] for j in range(n)))
for i in range(n):
    o = max(o, sum(a[j][i][j] for j in range(n)), sum(a[n - 1 - j][i][j] for j in range(n)))
for i in range(n):
    o = max(o, sum(a[j][j][i] for j in range(n)), sum(a[j][n - 1 - j][i] for j in range(n)))
print(
    max(
        o,
        sum(a[i][i][i] for i in range(n)),
        sum(a[i][i][n - 1 - i] for i in range(n)),
        sum(a[i][n - 1 - i][i] for i in range(n)),
        sum(a[i][n - 1 - i][n - 1 - i] for i in range(n)),
    )
)
