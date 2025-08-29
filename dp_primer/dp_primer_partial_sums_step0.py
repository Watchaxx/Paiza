# 実行時間 30ms
n, x = list(map(int, input().split()))
a = []
p = [False for _ in [0] * (x + 1)]

for _ in range(n):
    a.append(int(input()))
p[0] = True
for i in range(n):
    for j in range(x, a[i] - 1, -1):
        if p[j - a[i]] == True:
            p[j] = True
print("yes" if p[x] else "no")
