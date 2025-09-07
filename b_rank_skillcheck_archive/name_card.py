# 実行時間 40ms
i = 0
n, m = list(map(int, input().split()))

while True:
    if n * 2 * i + 1 <= m and m <= n * 2 * (i + 1):
        l = []

        for j in range(1, n * 2 + 1):
            l.append(n * 2 * i + j)

        idx = l.index(m)

        l.reverse()
        print(l[idx])
        break
    i += 1
