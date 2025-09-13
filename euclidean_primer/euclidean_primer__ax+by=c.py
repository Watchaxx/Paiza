# 実行時間 10ms
a, b, c = list(map(int, input().split()))
x = 0
y = 0

if a < b:
    y = 1
    x = (c - b) // a
else:
    x = 1
    y = (c - a) // b
print(x, y)
