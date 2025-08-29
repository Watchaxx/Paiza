# 実行時間 20ms
n, x, a, y, b = list(map(int, input().split()))
p = []

for _ in range(n + y):
    p.append(10000 * 1000)
p[0] = 0
for i in range(1, n + y):
    if x <= i:
        p[i] = min(p[i], p[i - x] + a)
    if y <= i:
        p[i] = min(p[i], p[i - y] + b)
for i in range(n + y - 2, 0, -1):
    p[i] = min(p[i], p[i + 1])
print(p[n])
