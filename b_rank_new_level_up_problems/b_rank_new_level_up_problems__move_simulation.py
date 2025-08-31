# 実行時間 20ms
c = 0
n = int(input())
t = []
y = []
x = []

for _ in [0] * n:
    r = list(map(int, input().split()))

    t.append(r[0])
    y.append(r[1])
    x.append(r[2])
for i in range(101):
    if i == t[c]:
        print(f"{y[c]} {x[c]}")
        c += 1
    else:
        print(f"{y[c - 1] + (i - t[c - 1]) * (y[c] - y[c - 1]) // (t[c] - t[c - 1])} {x[c - 1] + (i - t[c - 1]) * (x[c] - x[c - 1]) // (t[c] - t[c - 1])}")
