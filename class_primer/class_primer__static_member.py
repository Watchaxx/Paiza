class cus:
    def __init__(self):
        self.amo = 0

    def order(self, s, i):
        if s == "food" or s == "softdrink":
            self.amo += i

    def getAmount(self):
        return self.amo

class adu(cus):
    def __init__(self):
        super().__init__()
        self.dis = False

    def order(self, s, i):
        if s == "food":
            self.amo += i - 200 if self.dis else i
        elif s == "softdrink":
            self.amo += i
        elif s == "alcohol":
            self.amo += i
            self.dis = True

n, k = list(map(int, input().split()))
o = 0
l = []

for _ in range(n):
    a = int(input())

    l.append(cus() if a < 20 else adu())
for _ in range(k):
    s = input().split()

    if len(s) == 3:
        l[int(s[0]) - 1].order(s[1], int(s[2]))
    elif s[1] == "0":
        l[int(s[0]) - 1].order("alcohol", 500)
    elif s[1] == "A":
        o += 1
        print(cus.getAmount(l[int(s[0]) - 1]))
print(o)
