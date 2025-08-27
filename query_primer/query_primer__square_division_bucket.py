import math

N = 10000
r = N
s = math.floor(math.sqrt(N))

for _ in range(math.ceil(N / s)):
    a = []

    for i in range(min(r, s)):
        a.append(int(input()))
        r -= 1
    print(max(a))
# 実行時間 30ms
