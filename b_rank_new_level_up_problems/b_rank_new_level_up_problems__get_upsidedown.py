# 実行時間 10ms
h, w = list(map(int, input().split()))
a = [[False for i in range(w)] for j in range(h)]
DY = [-1, 1, 0, 0, 0]
DX = [0, 0, -1, 0, 1]

for i in range(h):
    s = input()

    for j, c in enumerate(s):
        if c == "#":
            a[i][j] = True

y, x = list(map(int, input().split()))

for i in range(5):
    o = y + DY[i]
    p = x + DX[i]

    if 0 <= o < h and 0 <= p < w:
        a[o][p] = not a[o][p]
for i in range(h):
    for j in range(w):
        print("#" if a[i][j] else ".", end="")
    print()
