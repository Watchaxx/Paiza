# 実行時間 20ms
h, w, d = list(map(int, input().split()))
a = [[0 for i in range(w)] for j in range(h)]
n = 0
y = 0
x = 0
l = []

while n < h * w:
    if 0 <= y < h and 0 <= x < w:
        n += 1
        a[y][x] = n
    if d == 1:
        y -= 1
        x += 1
        if y < 0:
            y = y + x + 1
            x = 0
    elif d == 2:
        x += 1
        if x == w:
            y += 1
            x = 0
    elif d == 3:
        y += 1
        if y == h:
            y = 0
            x += 1
    elif d == 4:
        y += 1
        x -= 1
        if x < 0:
            x = y + x + 1
            y = 0
for i in range(h):
    t = []

    for j in range(w):
        t.append(str(a[i][j]))
    l.append(" ".join(t))
print("\n".join(l))
