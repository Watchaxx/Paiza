# 実行時間 20ms
n, x, a, y, b, z, c = list(map(int, input().split()))
p = []

for _ in range(n + z):
    p.append(10000 * 1000)
p[0] = 0
for i in range(1, n + z):
    if x <= i:
        p[i] = min(p[i], p[i - x] + a)
    if y <= i:
        p[i] = min(p[i], p[i - y] + b)
    if z <= i:
        p[i] = min(p[i], p[i - z] + c)
for i in range(n + z - 2, 0, -1):
    p[i] = min(p[i], p[i + 1])
print(p[n])
