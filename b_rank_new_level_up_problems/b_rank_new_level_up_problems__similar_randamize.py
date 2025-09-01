# 実行時間 20ms
o = 0
x, m, n = list(map(int, input().split()))

for i in range(n):
    o += pow(x, i + 1)
    print(o % m)
