# 実行時間 10ms
def main():
    n = int(input())

    if n % 2 == 0:
        return False
    return pow(2, n - 1) % n == 1

print("YES" if main() else "NO")
