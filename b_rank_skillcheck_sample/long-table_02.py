# 実行時間 10ms
input()
o = 0
s = list(map(int, input().split()))

for i in s:
    if i == 0:
        o += 1
print(o)
