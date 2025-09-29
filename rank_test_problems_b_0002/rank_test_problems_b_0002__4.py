# 実行時間 10ms
n, m = list(map(int, input().split()))
g = [[0 for _ in [0] * m] for _ in [0] * n]
q = int(input())
z = 0

for _ in [0] * q:
    p, x, y = input().split()
    x = int(x) - 1
    y = int(y) - 1

    if -2 < g[x][y] < 2:
        if p == "A":
            g[x][y] += 1
        elif p == "B":
            g[x][y] -= 1
for i in g:
    for j in i:
        if 1 <= j:
            z += 1
        elif j <= -1:
            z -= 1
print("A" if 0 < z else "B" if z < 0 else "Draw")
