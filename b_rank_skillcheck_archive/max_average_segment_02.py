# 実行時間 190ms
n, k = list(map(int, input().split()))
a = list(map(int, input().split()))
b = []

for i in range(n - 1):
    b.append(a[i] + a[i + 1])
print(*b)
