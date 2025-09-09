# 実行時間 10ms
o = 0
n, m = list(map(int, input().split()))
s = []

for _ in [0] * n:
    s.append(input())
for i in range(min(len(s[0]), len(s[1]))):
    o += 1
    if s[0][i] != s[1][i]:
        break
print(s[m - 1][:o])
