n, x, p = list(map(int, input().split()))
l = [x, p]

for _ in range(n):
    l.append(int(input()))
l.sort()
print(l.index(p) + 1)
