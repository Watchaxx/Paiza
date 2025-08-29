# 実行時間 20ms
n, a, b, c = list(map(int, input().split()))
d = [1]

for i in range(1, n + 1):
    d.append(0)
    if a <= i:
        d[i] += d[i - a]
    if b <= i:
        d[i] += d[i - b]
    if c <= i:
        d[i] += d[i - c]
print(d[n])
