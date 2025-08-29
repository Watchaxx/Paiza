# 実行時間 10ms
k = int(input())
a = [1, 1]

for i in range(2, k):
    a.append(a[i - 2] + a[i - 1])
print(a[i])
