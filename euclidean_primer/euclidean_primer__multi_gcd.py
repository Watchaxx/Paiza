# 実行時間 10ms
import math

n = int(input())
a = int(input())

for _ in [0] * (n - 1):
    b = int(input())

    a = math.gcd(a, b)
print(a)
