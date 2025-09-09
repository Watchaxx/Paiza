# 実行時間 60ms
input()
mi = 0
mx = 0
b = list(map(int, input().split()))

for i in range(len(b)):
    if mx < b[i]:
        mi = i + 1
        mx = b[i]
print(mi)
