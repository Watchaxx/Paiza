# 実行時間 10ms
input()
a, b = list(map(int, input().split()))
o = []

for i in range(b, a + b):
    o.append(i)
print(*o)
