# 実行時間 10ms
h, w, n = list(map(int, input().split()))
t = [[0 for _ in [0] * w] for _ in [0] * h]

for i in range(h):
    t[i] = list(map(int, input().split()))

l = int(input())

for _ in [0] * l:
    a1, b1, a2, b2 = [int(x) - 1 for x in input().split()]

    print("YES" if t[a1][b1] == t[a2][b2] else "NO")
