# 実行時間 10ms
def extGcd(a, b):
    if b != 0:
        c, y, x = extGcd(b, a % b)

        y -= a // b * x
        return c, x, y
    return a, 1, 0

a, b = list(map(int, input().split()))
c = extGcd(a, b)
print(c[1], c[2])
