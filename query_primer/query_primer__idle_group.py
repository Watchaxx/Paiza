n, k = list(map(int, input().split()))
l = {input() for _ in range(n)}

for _ in range(k):
    s = input().split()

    if s[0] == "join":
        l.add(s[1])
    elif s[0] == "leave":
        l.remove(s[1])
    elif s[0] == "handshake" and 0 < len(l):
        print("\n".join(sorted(l)))
