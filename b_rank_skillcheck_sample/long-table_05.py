# 実行時間 10ms
n, m = list(map(int, input().split()))

for _ in [0] * m:
    a, b = list(map(int, input().split()))
    l = []

    for i in range(b, a + b):
        l.append(i - n if n < i else i)
    print(*l)
