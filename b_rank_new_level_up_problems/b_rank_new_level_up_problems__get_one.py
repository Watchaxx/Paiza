# 実行時間 20ms
h, w = list(map(int, input().split()))
a = [[False for i in range(w)] for j in range(h)]

for i in range(h):
    s = input()

    for j, c in enumerate(s):
        if c == "#":
            a[i][j] = True

y, x = list(map(int, input().split()))

a[y][x] = not a[y][x]
for i in range(h):
    for j in range(w):
        print("#" if a[i][j] else ".", end="")
    print()
