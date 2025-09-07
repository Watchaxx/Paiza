# 実行時間 10ms
h, w, n = list(map(int, input().split()))
t = [[0 for _ in [0] * w] for _ in [0] * h]

for i in range(h):
    t[i] = list(map(int, input().split()))

p = int(input())
a1, b1, a2, b2 = [int(x) - 1 for x in input().split()]

if t[a1][b1] == t[a2][b2]:
    print(f"YES\n{p}")
else:
    print("NO")
    print(1 if n < p + 1 else p + 1)
