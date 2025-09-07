# 実行時間 10ms
h, w, n = list(map(int, input().split()))
o = [0 for _ in [0] * n]
t = [[0 for _ in [0] * w] for _ in [0] * h]

for i in range(h):
    t[i] = list(map(int, input().split()))

c = 0
l = int(input())

for _ in [0] * l:
    a1, b1, a2, b2 = [int(x) - 1 for x in input().split()]

    if t[a1][b1] == t[a2][b2]:
        o[c] += 2
    else:
        c += 1
        if n <= c:
            c = 0
print("\n".join(map(str, o)))
