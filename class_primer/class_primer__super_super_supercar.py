class car:
    def __init__(self, f, c):
        self.cons = c
        self.fuel = f
        self.len = 0

    def getLen(self):
        return self.len

class sc(car):
    def __init__(self, f, c):
        super().__init__(f, c)

    def run(self):
        if 0 < self.fuel:
            self.fuel -= 1
            self.len += self.cons

class ssc(sc):
    def __init__(self, f, c):
        super().__init__(f, c)

    def fly(self):
        if 5 <= self.fuel:
            self.fuel -= 5
            self.len += self.cons * self.cons
        else:
            self.run()

class uc(ssc):
    def __init__(self, f, c):
        super().__init__(f, c)

    def fly(self):
        if 5 <= self.fuel:
            self.fuel -= 5
            self.len += 2 * self.cons * self.cons
        else:
            self.run()

    def telepo(self):
        if self.cons * self.cons <= self.fuel:
            self.fuel -= self.cons * self.cons
            self.len += pow(self.cons, 4)
        else:
            self.fly()

n, k = list(map(int, input().split()))
l = []

for _ in range(n):
    t = input().split()

    if t[0] == "supercar":
        l.append(sc(int(t[1]), int(t[2])))
    elif t[0] == "supersupercar":
        l.append(ssc(int(t[1]), int(t[2])))
    elif t[0] == "supersupersupercar":
        l.append(uc(int(t[1]), int(t[2])))
for _ in range(k):
    t = input().split()

    if t[1] == "run":
        l[int(t[0]) - 1].run()
    elif t[1] == "fly":
        l[int(t[0]) - 1].fly()
    elif t[1] == "teleport":
        l[int(t[0]) - 1].telepo()
for i in l:
    print(i.getLen())
