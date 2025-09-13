# 実行時間 10ms
i = 2
n = int(input())
l = []

while i * i <= n:
    if n % i != 0:
        i += 1
        continue
    while n % i == 0:
        l.append(i)
        n //= i
    i += 1
if n != 1:
    l.append(n)
print("\n".join(map(str, sorted(l))))
