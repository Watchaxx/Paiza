# 実行時間 20ms
n = int(input())
o = 0
t = 0
a = [[0 for i in range(n)] for j in range(n)]

for i in range(n):
    a[i] = list(map(int, input().split()))
for i in range(n):
    o = max(o, sum(a[i][0:n]))
for i in range(n):
    t = 0
    for j in range(n):
        t += a[j][i]
    o = max(o, t)
t = 0
for i in range(n):
    t += a[i][i]
o = max(o, t)
t = 0
for i in range(n):
    t += a[n - 1 - i][i]
print(max(o, t))
