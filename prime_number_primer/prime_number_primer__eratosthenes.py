# 実行時間 120ms
n = int(input())
p = [True] * (n + 1)

p[0] = False
p[1] = False
for i in range(2, n + 1):
    if p[i] == True:
        j = 2 * i
        while j <= n:
            p[j] = False
            j += i
print("YES" if p[n] else "NO")
