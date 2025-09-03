# 実行時間 10ms
n = int(input())
s = input()

if n < len(s):
    print(s[n - 1], s[n])
