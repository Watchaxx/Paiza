# 実行時間 20ms
n, a, b = list(map(int, input().split()))
d = [1]

for i in range(1, n + 1):
    d.append(0)
    if a <= i:
        d[i] += d[i - a]
    if b <= i:
        d[i] += d[i - b]
print(d[n])
