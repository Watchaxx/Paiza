# 実行時間 20ms
q = int(input())
a = [1, 1]

for i in range(2, 100):
    a.append(a[i - 2] + a[i - 1])
for _ in [0] * q:
    print(a[int(input()) - 1])
