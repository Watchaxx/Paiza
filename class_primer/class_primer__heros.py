class hero:
    def __init__(self, a):
        self.lvl = a[0]
        self.hlt = a[1]
        self.atk = a[2]
        self.dfd = a[3]
        self.agi = a[4]
        self.int = a[5]
        self.luk = a[6]

    def levelUp(self, a):
        self.lvl += 1
        self.hlt += int(a[2])
        self.atk += int(a[3])
        self.dfd += int(a[4])
        self.agi += int(a[5])
        self.int += int(a[6])
        self.luk += int(a[7])

    def muscleTraining(self, a):
        self.hlt += int(a[2])
        self.atk += int(a[3])

    def running(self, a):
        self.dfd += int(a[2])
        self.agi += int(a[3])

    def study(self, i):
        self.int += int(i[2])

    def pray(self, l):
        self.luk += int(l[2])

    def write(self):
        print(f"{self.lvl} {self.hlt} {self.atk} {self.dfd} {self.agi} {self.int} {self.luk}")

n, k = list(map(int, input().split()))
l = []

for _ in range(n):
    l.append(hero(list(map(int, input().split()))))
for _ in range(k):
    s = input().split()
    i = int(s[0]) - 1

    if s[1] == "levelup":
        l[i].levelUp(s)
    elif s[1] == "muscle_training":
        l[i].muscleTraining(s)
    elif s[1] == "running":
        l[i].running(s)
    elif s[1] == "study":
        l[i].study(s)
    elif s[1] == "pray":
        l[i].pray(s)
for i in l:
    i.write()
