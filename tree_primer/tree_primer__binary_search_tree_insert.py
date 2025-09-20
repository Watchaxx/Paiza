# 実行時間 10ms
n, r = list(map(int, input().split()))
bt = [-1] * 100100
lo = {}

bt[0] = r
lo[r] = 0
for _ in [0] * (n - 1):
    s = input().split()
    a = int(s[0])
    b = int(s[1])

    if s[2] == "L":
        lo[b] = 2 * lo[a] + 1
    elif s[2] == "R":
        lo[b] = 2 * lo[a] + 2
    bt[lo[b]] = b

c = 0
v = int(input())

while bt[c] != -1:
    c = 2 * c + 1 if v < bt[c] else 2 * c + 2
print(bt[(c - 1) // 2])
print("L" if c % 2 != 0 else "R")
