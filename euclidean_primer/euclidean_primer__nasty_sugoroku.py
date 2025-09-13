# 実行時間 10ms
import math

n, a = list(map(int, input().split()))
l = []

for i in range(1, 1001):
    if n % math.gcd(a, i) != 0 and a != i:
        l.append(i)
print("\n".join(map(str, l)) if 0 < len(l) else "-1")
