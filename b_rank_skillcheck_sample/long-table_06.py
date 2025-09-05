# 実行時間 10ms
import sys

n = int(input())
a, b = list(map(int, input().split()))
s = list(map(int, input().split()))

for i in range(b, a + b):
    t = i - n - 1 if n <= i else i - 1

    if s[t] == 0:
        s[t] = 1
    elif s[t] == 1:
        print("No")
        sys.exit()
print("Yes")
print(*s)
