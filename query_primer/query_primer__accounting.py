n, k = list(map(int, input().split()))
d = {}

for _ in range(n):
    d[input()] = {}
for _ in range(k):
    a, p, m = input().split()

    if p not in d[a]:
        d[a][p] = int(m)
    else:
        d[a][p] += int(m)
for k1, v1 in d.items():
    print(k1)
    for k2, v2 in d[k1].items():
        print(k2, v2)
    print("-----")
# 実行時間 410ms
