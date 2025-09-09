# 実行時間 10ms
n = int(input())

print(n)
for _ in [0] * n:
    print(*list(map(float, input().split())))
