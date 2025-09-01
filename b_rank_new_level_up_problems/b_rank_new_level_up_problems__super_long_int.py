# 実行時間 20ms
o = 0
x = input()

for i in range(4):
    t = []

    for j in range(8):
        t.append(x[8 * i + j])
    o += int("".join(t))
print(o)
