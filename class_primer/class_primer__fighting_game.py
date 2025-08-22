class player:
    def __init__(self, a):
        self.a = [a[2], a[4], a[6]]
        self.f = [a[1], a[3], a[5]]
        self.hp = a[0]

    def enhance(self, t):
        for i in range(3):
            if i != t:
                self.a[i] += 5
                self.f[i] = max(self.f[i] - 3, 1)

n, k = list(map(int, input().split()))
o = 0
l = []

for _ in range(n):
    l.append(player(list(map(int, input().split()))))
for _ in range(k):
    p1, t1, p2, t2 = list(map(int, input().split()))

    p1 -= 1
    t1 -= 1
    p2 -= 1
    t2 -= 1
    if l[p1].hp <= 0 or l[p2].hp <= 0:
        continue
    if l[p1].a[t1] == 0 and l[p1].f[t1] == 0:
        l[p1].enhance(t1)
        if l[p2].a[t2] == 0 and l[p2].f[t2] == 0:
            l[p2].enhance(t2)
        else:
            l[p1].hp -= l[p2].a[t2]
    elif l[p2].a[t2] == 0 and l[p2].f[t2] == 0:
        l[p2].hp -= l[p1].a[t1]
        l[p2].enhance(t2)
    else:
        if l[p1].f[t1] < l[p2].f[t2]:
            l[p2].hp -= l[p1].a[t1]
        elif l[p2].f[t2] < l[p1].f[t1]:
            l[p1].hp -= l[p2].a[t2]
for i in l:
    if 0 < i.hp:
        o += 1
print(o)
