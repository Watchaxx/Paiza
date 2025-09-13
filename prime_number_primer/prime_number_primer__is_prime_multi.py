# 実行時間 2910ms
# 素数判定を毎回行うと遅いのでエラトステネスの篩を使う
import sys

r=sys.stdin.readline
X = 6000000
n = int(r())
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
    print("pass" if p[int(r())] else "failure")
