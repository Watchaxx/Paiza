# 実行時間 10ms
n, x, k = list(map(int, input().split()))
o = k - n * 4

print(o // 4 * 2 * x + x if o % 4 == 3 else o // 4 * 2 * x)
