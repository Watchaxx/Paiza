n, k, p = list(map(int, input().split()))
l = [int(input()) for _ in range(n)]

l.append(p)

o = sorted(l).index(p) + 1

for _ in range(k):
    s = input().split()

    if s[0] == "join" and int(s[1]) < p:
        o += 1
    elif s[0] == "sorting":
        print(o)
