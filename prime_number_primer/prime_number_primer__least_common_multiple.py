# 実行時間 10ms
import math

n = int(input())
o = 1

for _ in [0] * n:
    a = int(input())
    o = o * a // math.gcd(o, a)
print(o)
