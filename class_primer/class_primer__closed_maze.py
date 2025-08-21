class maze:
    def __init__(self, a):
        self.a  = a[0]
        self.r1 = int(a[1]) - 1
        self.r2 = int(a[2]) - 1

n, k, s = list(map(int, input().split()))
l = []
o = []

for _ in range(n):
    l.append(maze(input().split()))
s -= 1
o.append(l[s].a)
for _ in range(k):
    s = l[s].r1 if input() == "1" else l[s].r2
    o.append(l[s].a)
print("".join(o))
