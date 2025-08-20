class student:
    def __init__(self, s):
        self.name = s[0]
        self.old = int(s[1])
        self.birth = s[2]
        self.state = s[3]

n = int(input())
l = []

for _ in range(n):
    l.append(student(input().split()))

k = int(input())

for i in l:
    if i.old == k:
        print(i.name)
        break
