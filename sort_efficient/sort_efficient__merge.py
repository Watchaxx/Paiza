# 実行時間 2630ms
def merge(a, l, m, r):
    global o
    li = 0
    ri = 0
    nl = m - l
    nr = r - m
    al = [0] * (nl + 1)
    ar = [0] * (nr + 1)

    for i in range(nl):
        al[i] = a[l + i]
    for i in range(nr):
        ar[i] = a[m + i]
    al[nl] = pow(10, 10) * 2
    ar[nr] = pow(10, 10) * 2
    for i in range(l, r):
        if al[li] < ar[ri]:
            a[i] = al[li]
            li += 1
        else:
            a[i] = ar[ri]
            ri += 1
            o += 1

def mergeSort(a, l, r):
    if l + 1 < r:
        m = (l + r) // 2

        mergeSort(a, l, m)
        mergeSort(a, m, r)
        merge(a, l, m, r)

n = int(input())
o = 0
a = list(map(int, input().split()))

mergeSort(a, 0, n)
print(*a)
print(o)
