import math

k = int(input())
N = 10000
s = math.floor(math.sqrt(N))
a = [0 for _ in range(N)]
m = [0 for _ in range(s)]

for i in range(N):
    a[i] = int(input())
for i in range(s):
    for j in range(s):
        m[i] = a[s * i] if j == 0 else max(m[i], a[s * i + j])
for _ in range(k):
    l, r = list(map(int, input().split()))
    l -= 1
    r -= 1
    i = l
    o = a[l]

    while i <= r:
        if i % s == 0 and i + s - 1 <= r:
            o = max(o, m[i // s])
            i += s
        else:
            o = max(o, a[i])
            i += 1
    print(o)
  # 実行時間 2570ms
