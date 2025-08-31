# 実行時間 20ms
x = int(input())
f1, f2 = list(map(int, input().split()))
l, n = list(map(int, input().split()))
s = list(map(int, input().split()))
c = 0
o = 0

s.append(l)
for i in range(n + 1):
    o += f1 * x + f2 * (s[i] - c - x) if x < s[i] - c else f1 * (s[i] - c)
    c = s[i]
print(o)
