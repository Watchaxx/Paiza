class user:
    def __init__(self, s):
        self.name = s[0]
        self.old = s[1]
        self.birth = s[2]
        self.state = s[3]

    def write(self):
        print("User{")
        print(f"nickname : {self.name}")
        print(f"old : {self.old}")
        print(f"birth : {self.birth}")
        print(f"state : {self.state}")
        print("}")

n = int(input())

for _ in range(n):
    i = user(input().split())

    i.write()
