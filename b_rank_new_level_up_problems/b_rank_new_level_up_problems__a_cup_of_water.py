# 実行時間 30ms
import itertools

o = 0
n, x = list(map(int, input().split()))
w = []

for _ in range(n):
    w.append(int(input()))
for i in range(n):
    t = 0
    l = list(itertools.combinations(w, i + 1))

    for j in range(len(l)):
        t = sum(l[j])
        if t <= x and o < t:
            o = t
print(o)
