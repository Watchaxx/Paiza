class employee:
    def __init__(self, num, name):
        self.num = num
        self.name = name

    def getnum(self):
        return self.num

    def getname(self):
        return self.name

n = int(input())
l = []

for _ in range(n):
    s = input().split()

    if s[0] == "make":
        l.append(employee(int(s[1]), s[2]))
    elif s[0] == "getnum":
        print(employee.getnum(l[int(s[1]) - 1]))
    elif s[0] == "getname":
        print(employee.getname(l[int(s[1]) - 1]))
