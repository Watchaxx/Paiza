# 実行時間 10ms
def main():
    n, r = list(map(int, input().split()))

    for _ in [0] * (n - 1):
        a, b = list(map(int, input().split()))

        if a < b:
            return "NO"
    return "YES"

print(main())
