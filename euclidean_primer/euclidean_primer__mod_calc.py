# 実行時間 20ms
n = int(input())
r = input().split()
a = int(r[0])
b = int(r[2])

if r[1] == "+":
    print((a % n + b % n) % n)
elif r[1] == "-":
    print((a % n - b % n + n) % n)
elif r[1] == "*":
    print((a % n) * (b % n) % n)
elif r[1] == "^":
    o = 1

    for _ in [0] * b:
        o *= a
        o %= n
    print(o)
