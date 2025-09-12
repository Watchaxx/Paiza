# 実行時間 7490ms
n = int(input())
a = list(map(int, input().split()))
k = int(input())
h = list(map(int, input().split()))

for i in h:
    m = 0

    for j in range(i, n):
        x = a[j]
        l = j - i

        while 0 <= l and x < a[l]:
            a[l + i] = a[l]
            l -= i
            m += 1
        a[l + i] = x
    print(m)
