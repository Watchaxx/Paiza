# 実行時間 10ms
x, d1, d2, k = list(map(int, input().split()))
a = [x]

for i in range(1, k):
    a.append(a[-1] + d1 if i % 2 == 0 else a[-1] + d2)
print(a[i])
