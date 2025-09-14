# 実行時間 10ms
def calcN(n):
    i = 2
    l = []

    while i * i <= n:
        while n % i == 0:
            l.append(i)
            n //= i
        i += 1
    if n != 1:
        l.append(n)
    return l

def extGcd(a, b):
    if b != 0:
        c, y, x = extGcd(b, a % b)

        y -= a // b * x
        return c, x, y
    return a, 1, 0

n, e, E = [3995747143, 3007, 602607029]
pr = calcN(n)
nd = (pr[0] - 1) * (pr[1] - 1)
b2 = f"{bin(pow(E, (nd + extGcd(e, nd)[1]) % nd, n))[2:]}"

while len(b2) % 7 != 0:
    b2 = "0" + b2
for i in range(0, len(b2), 7):
    b10 = int(b2[i : i + 7], 2)

    if b10 != 0:
        print(chr(b10), end="")
print()
