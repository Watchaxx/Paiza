h, w, n = list(map(int, input().split()))
a = [[0] * w for _ in range(h)]
s = [[0] * (w + 1) for _ in range(h + 1)]

for i in range(h):
    t = list(map(int, input().split()))

    for j in range(w):
        a[i][j] = t[j]
for i in range(w):
    s[0][i] = 0
for i in range(h):
    s[i][0] = 0
    for j in range(w):
        s[i + 1][j + 1] = s[i + 1][j] + s[i][j + 1] - s[i][j] + a[i][j]
for _ in range(n):
    aa, b, c, d = list(map(int, input().split()))
    lt = s[aa - 1][b - 1]
    lb = s[c][b - 1]
    rt = s[aa - 1][d]
    rb = s[c][d]

    print(rb - rt - lb + lt)
  # 実行時間 1020ms
