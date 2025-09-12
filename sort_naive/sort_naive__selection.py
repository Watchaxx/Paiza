# 実行時間 370ms
n = int(input())
a = list(map(int, input().split()))

for i in range(n - 1):
    mi = i

    for j in range(i + 1, n):
        if a[j] < a[mi]:
            mi = j
    a[i], a[mi] = a[mi], a[i]
    print(*a)
