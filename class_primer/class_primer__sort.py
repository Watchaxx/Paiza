class user:
    def __init__(self, s):
        self.name = s[0]
        self.old = int(s[1])
        self.birth = s[2]
        self.state = s[3]

n = int(input())
l = []

for _ in range(n):
    l.append(user(input().split()))
for i in sorted(l, key=lambda x: x.old):
    print(f"{i.name} {i.old} {i.birth} {i.state}")
