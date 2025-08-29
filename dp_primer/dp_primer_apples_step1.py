# 実行時間 10ms
import math

def main():
    n, a, b = list(map(int, input().split()))
    d = [0, a]

    if n == 1:
        return a
    for i in range(2, n + 1):
        d.append(min(d[i - 2] + a, b * math.ceil(i / 5)))
    return d[i]

print(main())
