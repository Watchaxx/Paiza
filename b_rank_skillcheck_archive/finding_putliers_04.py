# 実行時間 10ms
import math

input()
x1, y1 = list(map(float, input().split()))
x2, y2 = list(map(float, input().split()))
x3, y3 = list(map(float, input().split()))
a = y2 - y1
b = -(x2 - x1)
c = (x2 - x1) * y1 - a * x1
print(abs(a * x3 + b * y3 + c) / math.sqrt(a * a + b * b))
