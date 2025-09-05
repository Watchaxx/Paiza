# 実行時間 10ms
n = int(input())
a, b = list(map(int, input().split()))
l = []

for i in range(b, a + b):
    l.append(i - n if n < i else i)
print(*l)
