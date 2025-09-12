# 実行時間 1680ms
def quickSort(a, l, r):
    if r <= l + 1:
        return

    global o
    c = l
    p = a[r - 1]

    for i in range(l, r - 1):
        if a[i] < p:
            a[c], a[i] = a[i], a[c]
            c += 1
            o += 1
    a[c], a[r - 1] = a[r - 1], a[c]
    quickSort(a, l, c)
    quickSort(a, c + 1, r)

n = int(input())
o = 0
a = list(map(int, input().split()))

quickSort(a, 0, n)
print(*a)
print(o)
