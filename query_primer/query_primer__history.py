n, k = list(map(int, input().split()))
l = []

for _ in range(n):
    input()
for _ in range(k):
    s = input().split()

    l.append((int(s[0]), s[1]))
for k, v in sorted(l, key=lambda x: (x[0], x[1])):
    print(v)
