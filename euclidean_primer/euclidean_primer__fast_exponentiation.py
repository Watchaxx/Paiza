# 実行時間 10ms
a, b, m = list(map(int, input().split()))
o = 1

while 0 < b:
    if (b & 1) == 1:
        o = o * a % m
    a = a * a % m
    b >>= 1
print(o)
