n, k = list(map(int, input().split()))
l = [0]

for _ in range(n):
    l.append(l[-1] + int(input()))
for _ in range(k):
    a, b = list(map(int, input().split()))

    print(l[b] - l[a - 1])
# 実行時間 500ms
