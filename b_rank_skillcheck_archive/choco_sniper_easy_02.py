# 実行時間 10ms
def main():
    n, m = list(map(int, input().split()))

    if n == 0:
        return 0
    return max(sum(list(map(int, input().split()))), 0)

print(main())
