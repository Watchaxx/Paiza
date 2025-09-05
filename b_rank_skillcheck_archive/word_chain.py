# 実行時間 20ms
import sys

r = sys.stdin.readline
n, k, m = list(map(int, r().split()))
p = [True for _ in [0] * n]
l = 0
c = 0
o = n
d = []

for _ in [0] * k:
    d.append(r().strip())
for _ in [0] * m:
    s = r().strip()

    while p[c % n] != True:
        c += 1
    c %= n
    if s in d and (l == 0 or l == s[0]) and s[-1] != "z":
        l = s[-1]
    else:
        l = 0
        o -= 1
        p[c] = False
    if s in d:
        d.remove(s)
    c += 1
print(o)
for i in range(n):
    if p[i] == True:
        print(i + 1)
