# 実行時間 10ms
def main():
    o = 0
    n, m = list(map(int, input().split()))
    s = []

    m -= 1
    for _ in [0] * n:
        s.append(input())
    if n == 1:
        return(s[0][0])
    for i in range(n):
        if i == m:
            continue

        t = 0

        for j in range(min(len(s[m]), len(s[i]))):
            t += 1
            if s[i][j] != s[m][j]:
                break
        if o < t:
            o = t
    return(s[m][:o])

print(main())
