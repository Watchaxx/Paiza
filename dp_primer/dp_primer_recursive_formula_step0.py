# 実行時間 20ms
x, d, k = list(map(int, input().split()))
a = [x]

for _ in [0] * (k - 1):
    a.append(a[-1] + d)
print(a[-1])
