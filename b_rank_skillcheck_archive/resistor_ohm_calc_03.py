# 実行時間 10ms
n = int(input())
o = 0
d = {}

for _ in [0] * n:
    s = input().split()

    d[s[0]] = int(s[1])
input()
for i in input().split():
    o += d[i]
print(o)
