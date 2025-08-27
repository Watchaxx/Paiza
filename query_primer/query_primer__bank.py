n, k = list(map(int, input().split()))
dic = {}

for _ in range(n):
    c, p, d = input().split()

    dic[c] = (p, int(d))
for _ in range(k):
    g, m, w = input().split()
    pi, za = dic[g]

    if pi == m:
        dic[g] = (pi, za - int(w))
for key, val in dic.items():
    print(key, val[1])
# 実行時間 320ms
