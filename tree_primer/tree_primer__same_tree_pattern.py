# 実行時間 50ms
from itertools import permutations

def main():
    n1 = int(input())
    g1 = [[] for _ in [0] * n1]

    for _ in [0] * (n1 - 1):
        a, b = list(map(int, input().split()))

        a -= 1
        b -= 1
        g1[a].append(b)
        g1[b].append(a)

    n2 = int(input())
    g2 = [[] for _ in [0] * n2]

    for _ in [0] * (n2 - 1):
        a, b = list(map(int, input().split()))
        a -= 1
        b -= 1
        g2[a].append(b)
        g2[b].append(a)
    if n1 != n2:
        return False
    for i in permutations(range(n1)):
        c = True
        d = {}

        for j, k in enumerate(i):
            d[k] = j
        for j in range(n1):
            if len(g1[j]) != len(g2[d[j]]):
                c = False
                break
        if c == True:
            return True
    return False

print("YES" if main() else "NO")
