# 実行時間 120ms
n, k = list(map(int, input().split()))
a = list(map(int, input().split()))
b = [0] * (n - k + 1)
l = a[k:]
s = sum(a[:k])

for i in range(len(l)):
    l[i] -= a[i]
    b[i + 1] = b[i] + l[i]
for i in range(len(b)):
    b[i] += s
print(*b)
