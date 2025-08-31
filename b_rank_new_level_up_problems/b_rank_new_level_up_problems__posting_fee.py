# 実行時間 20ms
y, x, h = list(map(int, input().split()))
l = list(map(int, input().split()))
m = list(map(int, input().split()))

if h <= l[0]:
    if max(y, x) <= l[1]:
        print(m[0])
    elif y + x + h <= l[2]:
        print(m[1])
    else:
        print(m[2])
else:
    if max(y, x, h) <= l[3]:
        print(m[3])
    elif y + x + h <= l[4]:
        print(m[4])
    else:
        print(y * x * h * m[5])
