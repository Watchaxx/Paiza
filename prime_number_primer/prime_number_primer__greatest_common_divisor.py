# 実行時間 10ms
import math
import sys

def gcdM(a, n):
    o = a[0]

    for i in range(1, n):
        o = math.gcd(o, a[i])
    return o

r = sys.stdin.readline
n = int(r())
a = [0] * n

for i in range(n):
    a[i] = int(r())
print(gcdM(a, n))
