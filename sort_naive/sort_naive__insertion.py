# 実行時間 190ms
n = int(input())
a = list(map(int, input().split()))

for i in range(1, n):
    x = a[i]
    j = i - 1

    while 0 <= j and x < a[j]:
        a[j + 1] = a[j]
        j -= 1
    a[j + 1] = x
    print(*a)
