n, k = list(map(int, input().split()))
a = [0]

for i in range(n):
    a.append(a[-1] + int(input()))
for _ in range(k):
    al, ar, bl, br = list(map(int, input().split()))
    pa = ar - al + 1
    pb = br - bl + 1

    if n / 3 <= pa:
        print("DRAW" if n / 3 <= pb else "B")
        continue
    elif n / 3 <= pb:
        print("A")
        continue

    ia = a[ar] - a[al - 1]
    ib = a[br] - a[bl - 1]

    print("A" if ib < ia else "B" if ia < ib else "DRAW")
# 実行時間 290ms
