# 実行時間 10ms
n = int(input())
d = {}

for _ in [0] * n:
    s = input().split()

    d[s[0]] = int(s[1])
for i in sorted(d.items(), key=lambda x: x[0]):
    print(i[1])
