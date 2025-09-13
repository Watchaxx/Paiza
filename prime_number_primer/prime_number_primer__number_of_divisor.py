# 実行時間 10ms
i = 2
n = int(input())
o = 1
l = []

while i * i <= n:
    if n % i != 0:
        i += 1
        continue

    e = 0

    while n % i == 0:
        e += 1
        n //= i
    l.append(e)
if n != 1:
    l.append(1)
for i in l:
    o *= i + 1
print(o)
