# 実行時間 10ms
def extGcd(a, b):
    if b != 0:
        c, y, x = extGcd(b, a % b)

        y -= a // b * x
        return c, x, y
    return a, 1, 0

p, q, e, m = list(map(int, input().split()))
n = p * q
c = (p - 1) * (q - 1)
x = extGcd(e, c)[1]
d = (c + x) % c
e = pow(m, e, n)
f = pow(e, d, n)

print(d)
print(e)
print(f)
