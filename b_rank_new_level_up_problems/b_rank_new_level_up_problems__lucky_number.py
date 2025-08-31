# 実行時間 20ms
n = int(input())
o = 1000000
d = [0, 1, -1, "1"]
x = []

for _ in range(n):
    x.append(int(input()))
for i in range(n):
    for j in range(i + 1, n):
        for k in range(5):
            for l in range(5):
                n1 = 0
                n2 = 0

                if k == 3:
                    n1 = int(f"{d[3]}{x[i]}")
                elif k == 4:
                    n1 = int(f"{x[i]}{d[3]}")
                else:
                    n1 = x[i] + d[k]
                if l == 3:
                    n2 = int(f"{d[3]}{x[j]}")
                elif l == 4:
                    n2 = int(f"{x[j]}{d[3]}")
                else:
                    n2 = x[j] + d[l]
                o = min(o, abs(n1 - n2))
print(o)
