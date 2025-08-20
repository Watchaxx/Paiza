class user:
    def __init__(self, s):
        self.name = s[0]
        self.old = int(s[1])
        self.birth = s[2]
        self.state = s[3]

    def changeName(self, name):
        self.name = name

n, k = list(map(int, input().split()))
l = []

for _ in range(n):
    l.append(user(input().split()))
for i in range(k):
    s = input().split()

    l[int(s[0]) - 1].changeName(s[1])
for i in l:
    print(f"{i.name} {i.old} {i.birth} {i.state}")
