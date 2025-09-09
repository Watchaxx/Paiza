# 実行時間 20ms
n = int(input())
x = [0] * n
y = [0] * n

for i in range(n):
    f = list(map(float, input().split()))

    x[i] = f[0]
    y[i] = f[1]
for i in range(n - 1):
    for j in range(i + 1, n):
        print(y[j] - y[i], (x[j] - x[i]) * -1, (x[j] - x[i]) * y[i] - (y[j] - y[i]) * x[i])
