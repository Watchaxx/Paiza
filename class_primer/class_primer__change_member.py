class employee:
    def __init__(self, num, name):
        self.num = num
        self.name = name

    def change_name(self, name):
        self.name = name

    def change_num(self, num):
        self.num = num

    def getname(self):
        return self.name

    def getnum(self):
        return self.num

n = int(input())
l = []

for _ in range(n):
    s = input().split()
    i = int(s[1])

    if s[0] == "make":
        l.append(employee(i, s[2]))
    elif s[0] == "getnum":
        print(employee.getnum(l[i - 1]))
    elif s[0] == "getname":
        print(employee.getname(l[i - 1]))
    elif s[0] == "change_num":
        employee.change_num(l[i - 1], int(s[2]))
    elif s[0] == "change_name":
        employee.change_name(l[i - 1], s[2])
