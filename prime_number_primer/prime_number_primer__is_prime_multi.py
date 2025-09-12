# 実行時間 3590ms
# 毎回計算すると遅いのでエラトステネスの篩を使う
X = 6000000
n = int(input())
p = [True] * (X + 1)

p[0] = False
p[1] = False
for i in range(2, X + 1):
    if p[i] == True:
        j = 2 * i
        while j <= X:
            p[j] = False
            j += i
for _ in [0] * n:
    print("pass" if p[int(input())] else "failure")
