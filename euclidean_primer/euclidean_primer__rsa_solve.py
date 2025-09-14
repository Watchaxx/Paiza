# 実行時間 10ms
def extGcd(a, b):
    if b != 0:
        c, y, x = extGcd(b, a % b)

        y -= a // b * x
        return c, x, y
    return a, 1, 0

p, q, e, f = list(map(int, input().split()))
n = p * q
nd = (p - 1) * (q - 1)
x = extGcd(e, nd)[1]

print(chr(pow(f, (nd + x) % nd, n)))
