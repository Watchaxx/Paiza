# 実行時間 10ms
n, m = list(map(int, input().split()))
s = []

for _ in [0] * n:
    s.append(input())
print(s[m - 1])
