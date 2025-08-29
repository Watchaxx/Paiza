# 実行時間 20ms
n, a, b = list(map(int, input().split()))
d = [0, a]

for i in range(2, n + 1):
    d.append(min(d[i - 1] + a, d[i - 2] + b))
print(d[n])
