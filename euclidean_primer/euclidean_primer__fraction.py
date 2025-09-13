# 実行時間 10ms
import math

r = input().split()
a = int(r[0])
b = int(r[1])
c = int(r[3])
d = int(r[4])
ch = 0
mo = 0

if r[2] == "+":
    ch = a * d + b * c
    mo = b * d
elif r[2] == "-":
    ch = a * d - b * c
    mo = b * d
elif r[2] == "*":
    ch = a * c
    mo = b * d
elif r[2] == "/":
    ch = a * d
    mo = b * c
if mo < 0:
    ch *= -1
    mo *= -1

sh = math.gcd(abs(ch), abs(mo))

print(ch // sh, mo // sh)
