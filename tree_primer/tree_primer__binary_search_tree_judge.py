# 実行時間 10ms
def main():
    n, r = list(map(int, input().split()))
    bt = [-1] * 100100
    lo = {}

    bt[0] = r
    lo[r] = 0
    for _ in [0] * (n - 1):
        s = input().split()
        a = int(s[0])
        b = int(s[1])

        if s[2] == "L":
            if a <= b:
                return False
            lo[b] = 2 * lo[a] + 1
        elif s[2] == "R":
            if b <= a:
                return False
            lo[b] = 2 * lo[a] + 2
        if bt[lo[b]] != -1:
            return False
        else:
            bt[lo[b]] = b
    return True

print("YES" if main() else "NO")
