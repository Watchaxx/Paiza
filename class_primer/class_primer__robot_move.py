class robot:
    def __init__(self, a):
        self.x = a[0]
        self.y = a[1]
        self.l = a[2]

    def lvlUp(self):
        self.l = min(self.l + 1, 4)

    def move(self, d):
        s = [0, 1, 2, 5, 10]

        if d == "E":
            self.x += s[self.l]
        elif d == "W":
            self.x -= s[self.l]
        elif d == "S":
            self.y += s[self.l]
        elif d == "N":
            self.y -= s[self.l]

    def write(self):
        print(f"{self.x} {self.y} {self.l}")

TL = 10
h, w, n, k = list(map(int, input().split()))
tx = []
ty = []
l = []

for _ in range(TL):
    t = list(map(int, input().split()))

    tx.append(t[0])
    ty.append(t[1])
for _ in range(n):
    l.append(robot(list(map(int, input().split()))))
for _ in range(k):
    t = input().split()
    i = int(t[0]) - 1

    l[i].move(t[1])
    for j in range(TL):
        if l[i].x == tx[j] and l[i].y == ty[j]:
            l[i].lvlUp()
            break
for i in l:
    i.write()
