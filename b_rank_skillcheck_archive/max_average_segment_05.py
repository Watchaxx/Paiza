# 実行時間 130ms
n, k = list(map(int, input().split()))
a = list(map(int, input().split()))
b = [0] * (n - k + 1)
mc = 1
mi = -1
mx = -1
s = sum(a[:k])
l = a[k:]

for i in range(len(l)):
    l[i] -= a[i]
    b[i + 1] = b[i] + l[i]
for i in range(len(b)):
    b[i] += s
    if mx < b[i]:
        mc = 1
        mi = i + 1
        mx = b[i]
    elif mx == b[i]:
        mc += 1
print(mc, mi)
