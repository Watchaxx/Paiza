# 実行時間 10ms
def rnd(a, n):
    return a - n - 1 if n < a else a - 1

n, m = list(map(int, input().split()))
o = 0
s = [False for _ in [0] * n]

for _ in [0] * m:
    z = False
    a, b = list(map(int, input().split()))

    for i in range(b, a + b):
        if s[rnd(i, n)] == True:
            z = True
            break
    if z == True:
        continue
    for i in range(b, a + b):
        s[rnd(i, n)] = True
for i in s:
    if i == True:
        o += 1
print(o)
