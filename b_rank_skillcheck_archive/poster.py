# 実行時間 10ms
n = int(input())
a = int(input()) - 1
c = input() == "CW"
b = int(input())
z = [False] * n
l = []

z[a] = True
l.append(a + 1)
while True:
    i = 0

    while i < b:
        if c == True:
            a = a + 1 if a + 1 < n else 0
        else:
            a = a - 1 if 0 <= a - 1 else n - 1
        if z[a] != True:
            i += 1
    l.append(a + 1)
    z[a] = True
    if len(l) == n:
        break
print(*l)
