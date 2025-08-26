n, k = list(map(int, input().split()))
d = {}

for _ in range(n):
    s = input().split()

    d[s[0]] = s[1]
for _ in range(k):
    s = input().split()

    if s[0] == "join":
        d[s[1]] = s[2]
    elif s[0] == "call":
        print(d[s[1]])
