# 実行時間 20ms
x, d = list(map(int, input().split()))
q = int(input())
a = [x]

for _ in [0] * 1000:
    a.append(a[-1] + d)
for _ in [0] * q:
    print(a[int(input()) - 1])
