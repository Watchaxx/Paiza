# 実行時間 30ms
B = 200
n, x = list(map(int, input().split()))
a = []
p = [B for _ in [0] * (x + 1)]

for _ in range(n):
    a.append(int(input()))
p[0] = 0
for i in range(n):
    for j in range(x, a[i] - 1, -1):
        if p[j - a[i]] + 1 < p[j]:
            p[j] = p[j - a[i]] + 1
print(p[x] if p[x] != B else -1)
