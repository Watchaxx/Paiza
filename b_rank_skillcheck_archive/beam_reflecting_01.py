# 実行時間 10ms
h, w = list(map(int, input().split()))

for _ in [0] * h:
    s = input()
    l = [0] * w

    for i in range(w):
        if s[i] == "_":
            l[i] = 0
        elif s[i] == "/":
            l[i] = 1
        elif s[i] == "\\":
            l[i] = 2
    print(*l)
