# 実行時間 10ms
def isPrime(n):
    if n <= 2:
        return n == 2
    if n % 2 == 0:
        return False

    i = 3

    while i * i <= n:
        if n % i == 0:
            return False
        i += 2
    return True

print("YES" if isPrime(int(input())) else "NO")
