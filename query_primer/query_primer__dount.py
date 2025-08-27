h, w, n = list(map(int, input().split()))
a = [[0] * w for _ in range(h)]
s = [[0] * (w + 1) for _ in range(h + 1)]

for i in range(h):
    t = list(map(int, input().split()))

    for j in range(w):
        a[i][j] = t[j]
for i in range(h):
    for j in range(w):
        s[i + 1][j + 1] = s[i + 1][j] + s[i][j + 1] - s[i][j] + a[i][j]
for _ in range(n):
    t = list(map(int, input().split()))
    for i in range(len(t)):
        t[i] -= 1
    m = t[2] // 2
    lt = s[t[0] - m][t[1] - m]
    lb = s[t[0] + m + 1][t[1] - m]
    rt = s[t[0] - m][t[1] + m + 1]
    rb = s[t[0] + m + 1][t[1] + m + 1]
    os = rb - rt - lb + lt

    m = t[3] // 2
    lt = s[t[0] - m][t[1] - m]
    lb = s[t[0] + m + 1][t[1] - m]
    rt = s[t[0] - m][t[1] + m + 1]
    rb = s[t[0] + m + 1][t[1] + m + 1]
    print(os - (rb - rt - lb + lt))
# 実行時間 1160ms
