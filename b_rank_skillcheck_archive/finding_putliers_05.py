# 実行時間 10ms
import math

n = int(input())
o = 0
x = [0] * n
y = [0] * n

for i in range(n):
    x1, y1 = list(map(float, input().split()))

    x[i] = x1
    y[i] = y1

a = y[1] - y[0]
b = -(x[1] - x[0])
c = (x[1] - x[0]) * y[0] - a * x[0]

for i in range(2, n):
    if 2 <= abs(a * x[i] + b * y[i] + c) / math.sqrt(a * a + b * b):
        o += 1
print(o)
