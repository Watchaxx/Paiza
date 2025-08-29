# 実行時間 40ms
n, x = list(map(int, input().split()))
a = []
p = [0 for _ in [0] * (x + 1)]

for _ in [0] * n:
    a.append(int(input()))
p[0] = 1
for i in range(n):
    for j in range(x, a[i] - 1, -1):
        p[j] += p[j - a[i]]
        p[j] %= 1000000007
print(p[x])
