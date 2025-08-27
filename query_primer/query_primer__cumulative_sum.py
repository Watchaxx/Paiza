n, k = list(map(int, input().split()))
l = [0]

for _ in range(n):
    l.append(l[-1] + int(input()))
for _ in range(k):
    print(l[int(input())])
# 実行時間 380ms
