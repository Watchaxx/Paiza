# 実行時間 10ms
n, k, r = list(map(int, input().split()))
s = set()

s.add(r)
for _ in [0] * (n - 1):
    a, b = list(map(int, input().split()))

    s.add(a)
    s.add(b)
for _ in [0] * k:
    print("Yes" if int(input()) in s else "No")
