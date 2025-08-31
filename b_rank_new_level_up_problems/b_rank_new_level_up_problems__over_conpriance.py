# 実行時間 20ms
import math

n = int(input())
s = input()
s1 = s[: math.ceil(len(s) / 2)]
s2 = s[len(s) // 2 :]
x = "".join("x" for _ in range(len(s1)))

for _ in range(n):
    v = input()

    if len(v) != len(s):
        print(v)
        continue
    if v == s:
        print("banned")
    elif v.startswith(s1) == True:
        print(f"{x}{v[len(s1) :]}")
    elif v.endswith(s2) == True:
        print(f"{v[: len(s)//2]}{x}")
    else:
        print(v)
