# 実行時間 10ms
n, q = list(map(int, input().split()))
b = [0] * n

for _ in [0] * q:
    p, x = input().split()
    x = int(x) - 1

    if b[x] == 0 and p == "A":
        b[x] = 1
    elif b[x] == 0 and p == "B":
        b[x] = -1
print("A" if 0 < sum(b) else "B" if sum(b) < 0 else "Draw")
